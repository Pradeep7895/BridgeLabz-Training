using HealthClinic.Models;

namespace HealthClinic.Interfaces
{
    public interface IDoctorService
    {
        Task AddDoctorAsync(Doctor doctor);
        Task UpdateDoctorSpecialtyAsync(int doctorId, int specialtyId);
        Task<List<Doctor>> GetDoctorsBySpecialtyAsync(string specialtyName);
        Task DeactivateDoctorAsync(int doctorId);
        Task DisplaySpecialtiesAsync();
    }
}