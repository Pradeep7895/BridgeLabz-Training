using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinic.Models;
using HealthClinic.Interfaces;
using HealthClinic.Connection;

namespace HealthClinic.Services
{
    public class VisitService : IVisitService
    {
        public async Task<int> RecordVisitAsync(Visit visit)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPRecord_Visit", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@appointment_id", visit.AppointmentId);
            command.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
            command.Parameters.AddWithValue("@prescription", visit.Prescription);
            command.Parameters.AddWithValue("@notes", visit.Notes);

            var outputParam = new SqlParameter("@visit_id", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            command.Parameters.Add(outputParam);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();

            return (int)outputParam.Value;
        }

        public async Task AddPrescriptionAsync(int visitId, Prescription prescription)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPAdd_Prescriptions", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@visit_id", visitId);
            command.Parameters.AddWithValue("@medicine_name", prescription.MedicineName);
            command.Parameters.AddWithValue("@dosage", prescription.Dosage);
            command.Parameters.AddWithValue("@duration", prescription.Duration);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task<List<MedicalHistoryDTO>> GetMedicalHistoryAsync(int patientId)
        {
            var list = new List<MedicalHistoryDTO>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPGet_Patient_Medical_History", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@patient_id", patientId);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new MedicalHistoryDTO
                {
                    VisitDate = (DateTime)reader["visit_date"],
                    Diagnosis = reader["diagnosis"]?.ToString(),
                    Prescription = reader["prescription"]?.ToString(), 
                    Notes = reader["notes"]?.ToString(),
                    MedicineName = reader["medicine_name"]?.ToString(),
                    Dosage = reader["dosage"]?.ToString(),
                    Duration = reader["duration"]?.ToString()
                });
            }

            return list;
        }
    }
}