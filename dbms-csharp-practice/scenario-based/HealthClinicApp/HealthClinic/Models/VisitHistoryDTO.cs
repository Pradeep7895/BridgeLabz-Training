namespace HealthClinic.Models
{
    public class VisitHistoryDTO
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string DoctorName { get; set; }
        public string Diagnosis { get; set; }
        public string VisitNotes { get; set; }
    }
}