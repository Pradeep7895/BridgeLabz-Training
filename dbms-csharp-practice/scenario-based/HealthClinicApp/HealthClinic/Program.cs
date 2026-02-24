using HealthClinic.Menu;

class Program
{
    static async Task Main()
    {
        while (true)
        {
            Console.WriteLine("\n====== Health Clinic Management System ======");
            Console.WriteLine("1. Patient Management");
            Console.WriteLine("2. Doctor Management");
            Console.WriteLine("3. Appointment Management");
            Console.WriteLine("4. Visit Management");
            Console.WriteLine("5. Billing & Payments");
            Console.WriteLine("6. System Administration");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    await new PatientMenu().ShowAsync();
                    break;

                case 2:
                    await new DoctorMenu().ShowAsync();
                    break;

                case 3:
                    await new AppointmentMenu().ShowAsync();
                    break;

                case 4:
                    await new VisitMenu().ShowAsync();
                    break;

                case 5:
                    await new BillingMenu().ShowAsync();
                    break;
                case 6:
                    await new AdminMenu().ShowAsync();
                    break;

                case 7:
                    Console.WriteLine("Exiting system...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}