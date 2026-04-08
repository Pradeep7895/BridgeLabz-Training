using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinic.Connection;
using HealthClinic.Interfaces;
using HealthClinic.Models;

namespace HealthClinic.Services
{
    public class BillingService : IBillingService
    {
        public async Task GenerateBillAsync(int visitId, decimal additionalCharges)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPGenerate_Bill", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@visit_id", visitId);
            command.Parameters.AddWithValue("@additional_charges", additionalCharges);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task RecordPaymentAsync(int billId, string paymentMode)
        {
            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPRecord_Payment", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@bill_id", billId);
            command.Parameters.AddWithValue("@payment_mode", paymentMode);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();
        }

        public async Task<List<BillSummaryDTO>> GetOutstandingBillsAsync()
        {
            var list = new List<BillSummaryDTO>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPGet_Outstanding_Bills", connection);
            command.CommandType = CommandType.StoredProcedure;

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new BillSummaryDTO
                {
                    PatientId = (int)reader["patient_id"],
                    PatientName = reader["full_name"].ToString(),
                    TotalUnpaidBills = (int)reader["total_unpaid_bills"],
                    TotalDue = (decimal)reader["total_due"]
                });
            }

            return list;
        }

        public async Task<List<RevenueDTO>> GetRevenueReportAsync(DateTime start, DateTime end)
        {
            var list = new List<RevenueDTO>();

            using var connection = DbConnectionFactory.CreateConnection();
            using var command = new SqlCommand("SPRevenue_Report", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@start_date", start);
            command.Parameters.AddWithValue("@end_date", end);

            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new RevenueDTO
                {
                    DoctorName = reader["doctor_name"].ToString(),
                    TotalRevenue = (decimal)reader["total_revenue"]
                });
            }

            return list;
        }
    }
}