namespace HealthClinic.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; }
        public int SpecialtyId { get; set; }
        public string Phone { get; set; }
        public decimal ConsultationFee { get; set; }
        public bool IsActive { get; set; }
    }
}