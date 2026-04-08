namespace HealthClinic.Models
{
    public class BillSummaryDTO
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int TotalUnpaidBills { get; set; }
        public decimal TotalDue { get; set; }
    }
}