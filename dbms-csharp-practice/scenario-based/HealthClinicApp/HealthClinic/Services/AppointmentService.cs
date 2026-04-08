using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinic.Interfaces;
using HealthClinic.Models;
using HealthClinic.Connection;

namespace HealthClinic.Services
{
    public class AppointmentService : IAppointmentService
    {
        public async Task BookAppointmentAsync(Appointment appointment)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPBook_Appointment", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@patient_id", appointment.PatientId);
            command.Parameters.AddWithValue("@doctor_id", appointment.DoctorId);
            command.Parameters.AddWithValue("@appointment_date", appointment.AppointmentDate);
            command.Parameters.AddWithValue("@appointment_time", appointment.AppointmentTime);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task CheckDoctorAvailabilityAsync(int doctorId, DateTime date)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPCheck_Doctor_Availability", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@doctor_id", doctorId);
            command.Parameters.AddWithValue("@appointment_date", date);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            Console.WriteLine("\nTime Slot | Booked Count");
            while (await reader.ReadAsync())
            {
                Console.WriteLine($"{reader["appointment_time"]} | {reader["booked_count"]}");
            }
        }

        public async Task CancelAppointmentAsync(int appointmentId)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPCancel_Appointment", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@appointment_id", appointmentId);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task RescheduleAppointmentAsync(int appointmentId, DateTime newDate, TimeSpan newTime, int newDoctorId)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPReschedule_Appointment", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@appointment_id", appointmentId);
            command.Parameters.AddWithValue("@new_date", newDate);
            command.Parameters.AddWithValue("@new_time", newTime);
            command.Parameters.AddWithValue("@new_doctor_id", newDoctorId);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task<List<DailyScheduleDTO>> GetDailyScheduleAsync(DateTime date)
        {
            var list = new List<DailyScheduleDTO>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPGet_Daily_Schedule", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@appointment_date", date);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new DailyScheduleDTO
                {
                    AppointmentId = (int)reader["appointment_id"],
                    AppointmentTime = (TimeSpan)reader["appointment_time"],
                    PatientName = reader["patient_name"].ToString(),
                    DoctorName = reader["doctor_name"].ToString(),
                    Status = reader["status"].ToString()
                });
            }

            return list;
        }
    }
}