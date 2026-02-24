using HealthClinic.Models;

namespace HealthClinic.Interfaces
{
    public interface IVisitService
    {
        Task<int> RecordVisitAsync(Visit visit);
        Task AddPrescriptionAsync(int visitId, Prescription prescription);
        Task<List<MedicalHistoryDTO>> GetMedicalHistoryAsync(int patientId);
    }
}