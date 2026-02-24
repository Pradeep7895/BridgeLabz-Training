namespace HealthClinic.Models
{
    public class DailyScheduleDTO
    {
        public int AppointmentId { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Status { get; set; }
    }
}