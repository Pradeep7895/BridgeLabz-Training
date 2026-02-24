using HealthClinic.Services;

namespace HealthClinic.Menu
{
    public class BillingMenu
    {
        private readonly BillingService service = new();

        public async Task ShowAsync()
        {
            while (true)
            {
                Console.WriteLine("\n--- Billing & Payments ---");
                Console.WriteLine("1. Generate Bill");
                Console.WriteLine("2. Record Payment");
                Console.WriteLine("3. View Outstanding Bills");
                Console.WriteLine("4. Revenue Report");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        Console.Write("Visit ID: ");
                        int visitId = int.Parse(Console.ReadLine()!);
                        Console.Write("Additional Charges: ");
                        decimal charges = decimal.Parse(Console.ReadLine()!);
                        await service.GenerateBillAsync(visitId, charges);
                        Console.WriteLine("Bill generated!");
                        break;

                    case 2:
                        Console.Write("Bill ID: ");
                        int billId = int.Parse(Console.ReadLine()!);
                        Console.Write("Payment Mode: ");
                        string mode = Console.ReadLine();
                        await service.RecordPaymentAsync(billId, mode);
                        Console.WriteLine("Payment recorded!");
                        break;

                    case 3:
                        var bills = await service.GetOutstandingBillsAsync();
                        foreach (var b in bills)
                        {
                            Console.WriteLine($"{b.PatientName} | Bills: {b.TotalUnpaidBills} | Due: {b.TotalDue}");
                        }
                        break;

                    case 4:
                        Console.Write("Start Date (yyyy-mm-dd): ");
                        DateTime start = DateTime.Parse(Console.ReadLine()!);
                        Console.Write("End Date (yyyy-mm-dd): ");
                        DateTime end = DateTime.Parse(Console.ReadLine()!);

                        var revenue = await service.GetRevenueReportAsync(start, end);
                        foreach (var r in revenue)
                        {
                            Console.WriteLine($"{r.DoctorName} | Revenue: {r.TotalRevenue}");
                        }
                        break;

                    case 5:
                        return;
                }
            }
        }
    }
}