using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinic.Connection;
using HealthClinic.Interfaces;
using HealthClinic.Models;
using HealthClinic.Exceptions;

namespace HealthClinic.Services
{
    public class PatientService : IPatientService
    {
        public async Task RegisterPatientAsync(Patient patient)
        {
            try
            {
                using var connection = DbConnectionFactory.CreateConnection();
                using var command = new SqlCommand("SPRegister_Patient", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", patient.FullName);
                command.Parameters.AddWithValue("@dob", patient.DOB);
                command.Parameters.AddWithValue("@phone", patient.Phone);
                command.Parameters.AddWithValue("@email", patient.Email);
                command.Parameters.AddWithValue("@address", patient.Address);
                command.Parameters.AddWithValue("@blood_group", patient.BloodGroup);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new ValidationException(ex.Message);
            }
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPUpdate_Patient", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@patient_id", patient.PatientId);
            command.Parameters.AddWithValue("@full_name", patient.FullName);
            command.Parameters.AddWithValue("@dob", patient.DOB);
            command.Parameters.AddWithValue("@phone", patient.Phone);
            command.Parameters.AddWithValue("@email", patient.Email);
            command.Parameters.AddWithValue("@address", patient.Address);
            command.Parameters.AddWithValue("@blood_group", patient.BloodGroup);

            await connection.OpenAsync();
            int rows = await command.ExecuteNonQueryAsync();

            if (rows == 0)
                throw new NotFoundException("Patient not found.");
        }

        public async Task<List<Patient>> SearchPatientsAsync(string searchTerm)
        {
            var patients = new List<Patient>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand(
                @"SELECT * FROM Patients
                WHERE full_name LIKE @term
                OR phone = @exact
                OR patient_id = TRY_CAST(@exact AS INT)", connection);

            command.Parameters.AddWithValue("@term", $"%{searchTerm}%");
            command.Parameters.AddWithValue("@exact", searchTerm);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                patients.Add(new Patient
                {
                    PatientId = (int)reader["patient_id"],
                    FullName = reader["full_name"].ToString(),
                    DOB = (DateTime)reader["dob"],
                    Phone = reader["phone"].ToString(),
                    Email = reader["email"].ToString(),
                    Address = reader["address"].ToString(),
                    BloodGroup = reader["blood_group"].ToString()
                });
            }

            return patients;
        }

        public async Task<List<VisitHistoryDTO>> GetVisitHistoryAsync(int patientId)
        {
            var history = new List<VisitHistoryDTO>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPGet_Patient_Visit_History", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@patient_id", patientId);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                history.Add(new VisitHistoryDTO
                {
                    AppointmentId = (int)reader["appointment_id"],
                    AppointmentDate = (DateTime)reader["appointment_date"],
                    DoctorName = reader["doctor_name"].ToString(),
                    Diagnosis = reader["diagnosis"]?.ToString(),
                    VisitNotes = reader["visit_notes"]?.ToString()
                });
            }

            return history;
        }
    }
}