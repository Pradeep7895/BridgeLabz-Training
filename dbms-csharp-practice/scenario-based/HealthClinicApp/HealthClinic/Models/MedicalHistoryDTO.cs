namespace HealthClinic.Models
{
    public class MedicalHistoryDTO
    {
        public DateTime VisitDate { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; } 
        public string Notes { get; set; }
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public string Duration { get; set; }
    }
}