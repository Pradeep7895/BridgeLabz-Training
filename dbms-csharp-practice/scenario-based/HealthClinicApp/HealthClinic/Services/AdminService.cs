using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinic.Connection;
using HealthClinic.Interfaces;
using HealthClinic.Models;

namespace HealthClinic.Services
{
    public class AdminService : IAdminService
    {
        public async Task AddSpecialtyAsync(string name)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("SPAdd_Specialty", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@specialty_name", name);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task UpdateSpecialtyAsync(int id, string name)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("SPUpdate_Specialty", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@specialty_id", id);
            cmd.Parameters.AddWithValue("@specialty_name", name);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteSpecialtyAsync(int id)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("SPDelete_Specialty", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@specialty_id", id);

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<Specialty>> GetAllSpecialtiesAsync()
        {
            var list = new List<Specialty>();

            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("SPGet_All_Specialties", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new Specialty
                {
                    SpecialtyId = (int)reader["specialty_id"],
                    SpecialtyName = reader["specialty_name"].ToString()
                });
            }

            return list;
        }

        public async Task BackupDatabaseAsync()
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("SPBackup_Database", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<AuditLogDTO>> GetAuditLogsAsync(string table, string operation)
        {
            var list = new List<AuditLogDTO>();

            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("SPGet_Audit_Logs", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@table_name",
                string.IsNullOrEmpty(table) ? DBNull.Value : table);

            cmd.Parameters.AddWithValue("@operation",
                string.IsNullOrEmpty(operation) ? DBNull.Value : operation);

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new AuditLogDTO
                {
                    TableName = reader["table_name"].ToString(),
                    Operation = reader["operation"].ToString(),
                    RecordId = (int)reader["record_id"],
                    ChangedAt = (DateTime)reader["changed_at"]
                });
            }

            return list;
        }
    }
}