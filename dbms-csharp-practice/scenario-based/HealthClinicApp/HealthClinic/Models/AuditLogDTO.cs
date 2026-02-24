namespace HealthClinic.Models
{
    public class AuditLogDTO
    {
        public string TableName { get; set; }
        public string Operation { get; set; }
        public int RecordId { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}