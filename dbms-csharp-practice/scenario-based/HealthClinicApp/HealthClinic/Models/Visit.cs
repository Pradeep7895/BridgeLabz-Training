namespace HealthClinic.Models
{
    public class Visit
    {
        public int AppointmentId { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; } 
        public string Notes { get; set; }
    }
}