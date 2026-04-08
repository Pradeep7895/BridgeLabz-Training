using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinic.Models;
using HealthClinic.Interfaces;
using HealthClinic.Connection;
using HealthClinic.Exceptions;

namespace HealthClinic.Services
{
    public class DoctorService : IDoctorService
    {
        public async Task AddDoctorAsync(Doctor doctor)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPAdd_Doctor", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@name", doctor.FullName);
            command.Parameters.AddWithValue("@specialty_id", doctor.SpecialtyId);
            command.Parameters.AddWithValue("@contact", doctor.Phone);
            command.Parameters.AddWithValue("@fee", doctor.ConsultationFee);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task UpdateDoctorSpecialtyAsync(int doctorId, int specialtyId)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPUpdate_Doctor_Specialty", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@doctor_id", doctorId);
            command.Parameters.AddWithValue("@specialty_id", specialtyId);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task<List<Doctor>> GetDoctorsBySpecialtyAsync(string specialtyName)
        {
            var doctors = new List<Doctor>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPGet_Doctors_By_Specialty", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@specialty_name", specialtyName);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                doctors.Add(new Doctor
                {
                    DoctorId = (int)reader["doctor_id"],
                    FullName = reader["full_name"].ToString(),
                    Phone = reader["contact"]?.ToString(),
                    ConsultationFee = (decimal)reader["consultation_fee"],
                    IsActive = (bool)reader["is_active"]
                });
            }

            return doctors;
        }

        public async Task DeactivateDoctorAsync(int doctorId)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPDeactivate_Doctor", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@doctor_id", doctorId);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task DisplaySpecialtiesAsync()
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SELECT specialty_id, specialty_name FROM Specialties", connection);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            Console.WriteLine("\nAvailable Specialties:");

            while (await reader.ReadAsync())
            {
                Console.WriteLine($"ID: {reader["specialty_id"]} | Name: {reader["specialty_name"]}");
            }
        }
    }
}