using HealthClinic.Models;
using HealthClinic.Services;

namespace HealthClinic.Menu
{
    public class PatientMenu
    {
        private readonly PatientService service = new();

        public async Task ShowAsync()
        {
            while (true)
            {
                Console.WriteLine("\n1. Register Patient");
                Console.WriteLine("2. Update Patient");
                Console.WriteLine("3. Search Patient");
                Console.WriteLine("4. View Visit History");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        await RegisterAsync();
                        break;
                    case 2:
                        await UpdateAsync();
                        break;
                    case 3:
                        await SearchAsync();
                        break;
                    case 4:
                        await VisitHistoryAsync();
                        break;
                    case 5:
                        return;
                }
            }
        }

        private async Task RegisterAsync()
        {
            var patient = new Patient();

            Console.Write("Name: ");
            patient.FullName = Console.ReadLine();

            Console.Write("DOB (yyyy-mm-dd): ");
            patient.DOB = DateTime.Parse(Console.ReadLine());

            Console.Write("Phone: ");
            patient.Phone = Console.ReadLine();

            Console.Write("Email: ");
            patient.Email = Console.ReadLine();

            Console.Write("Address: ");
            patient.Address = Console.ReadLine();

            Console.Write("Blood Group: ");
            patient.BloodGroup = Console.ReadLine();

            await service.RegisterPatientAsync(patient);

            Console.WriteLine("Patient Registered Successfully!");
        }

        private async Task UpdateAsync()
        {
            var patient = new Patient();

            Console.Write("Patient ID: ");
            patient.PatientId = int.Parse(Console.ReadLine());

            Console.Write("New Name: ");
            patient.FullName = Console.ReadLine();

            Console.Write("New DOB: ");
            patient.DOB = DateTime.Parse(Console.ReadLine());

            Console.Write("New Phone: ");
            patient.Phone = Console.ReadLine();

            Console.Write("New Email: ");
            patient.Email = Console.ReadLine();

            Console.Write("New Address: ");
            patient.Address = Console.ReadLine();

            Console.Write("New Blood Group: ");
            patient.BloodGroup = Console.ReadLine();

            await service.UpdatePatientAsync(patient);

            Console.WriteLine("Patient Updated Successfully!");
        }

        private async Task SearchAsync()
        {
            Console.Write("Enter Name/Phone/ID: ");
            string term = Console.ReadLine();

            var results = await service.SearchPatientsAsync(term);

            foreach (var p in results)
            {
                Console.WriteLine($"{p.PatientId} | {p.FullName} | {p.Phone}");
            }
        }

        private async Task VisitHistoryAsync()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            var history = await service.GetVisitHistoryAsync(id);

            foreach (var h in history)
            {
                Console.WriteLine($"{h.AppointmentDate} | {h.DoctorName} | {h.Diagnosis}");
            }
        }
    }
}