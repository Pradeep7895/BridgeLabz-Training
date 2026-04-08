using HealthClinic.Models;

namespace HealthClinic.Interfaces
{
    public interface IPatientService
    {
        Task RegisterPatientAsync(Patient patient);
        Task UpdatePatientAsync(Patient patient);
        Task<List<Patient>> SearchPatientsAsync(string searchTerm);
        Task<List<VisitHistoryDTO>> GetVisitHistoryAsync(int patientId);
    }
}