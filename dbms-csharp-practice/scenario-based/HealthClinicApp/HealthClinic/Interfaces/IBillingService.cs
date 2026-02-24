using HealthClinic.Models;

namespace HealthClinic.Interfaces
{
    public interface IBillingService
    {
        Task GenerateBillAsync(int visitId, decimal additionalCharges);
        Task RecordPaymentAsync(int billId, string paymentMode);
        Task<List<BillSummaryDTO>> GetOutstandingBillsAsync();
        Task<List<RevenueDTO>> GetRevenueReportAsync(DateTime start, DateTime end);
    }
}