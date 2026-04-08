using HealthClinic.Models;

namespace HealthClinic.Interfaces
{
    public interface IAdminService
    {
        Task AddSpecialtyAsync(string name);
        Task UpdateSpecialtyAsync(int id, string name);
        Task DeleteSpecialtyAsync(int id);
        Task<List<Specialty>> GetAllSpecialtiesAsync();
        Task BackupDatabaseAsync();
        Task<List<AuditLogDTO>> GetAuditLogsAsync(string table, string user);
    }
}