using HealthClinic.Models;
using HealthClinic.Services;

namespace HealthClinic.Menu
{
    public class VisitMenu
    {
        private readonly VisitService service = new();

        public async Task ShowAsync()
        {
            while (true)
            {
                Console.WriteLine("\n--- Visit & Medical Records ---");
                Console.WriteLine("1. Record Patient Visit");
                Console.WriteLine("2. View Patient Medical History");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        await RecordVisitAsync();
                        break;

                    case 2:
                        await ViewHistoryAsync();
                        break;

                    case 3:
                        return;
                }
            }
        }

        private async Task RecordVisitAsync()
        {
            var visit = new Visit();

            Console.Write("Appointment ID: ");
            visit.AppointmentId = int.Parse(Console.ReadLine()!);

            Console.Write("Diagnosis: ");
            visit.Diagnosis = Console.ReadLine();

            Console.Write("Prescription Summary: ");
            visit.Prescription = Console.ReadLine();

            Console.Write("Notes: ");
            visit.Notes = Console.ReadLine();

            try
            {
                int visitId = await service.RecordVisitAsync(visit);

                Console.WriteLine("Visit recorded successfully!");
                Console.WriteLine($"Generated Visit ID: {visitId}");

                await AddPrescriptionsAsync(visitId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private async Task AddPrescriptionsAsync(int visitId)
        {
            Console.WriteLine("\nAdd Prescription Details");
            Console.Write("How many medicines to add? ");

            int count = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < count; i++)
            {
                var prescription = new Prescription();

                Console.WriteLine($"\nMedicine {i + 1}");

                Console.Write("Medicine Name: ");
                prescription.MedicineName = Console.ReadLine();

                Console.Write("Dosage: ");
                prescription.Dosage = Console.ReadLine();

                Console.Write("Duration: ");
                prescription.Duration = Console.ReadLine();

                await service.AddPrescriptionAsync(visitId, prescription);
            }

            Console.WriteLine("Prescriptions added successfully!");
        }

        private async Task ViewHistoryAsync()
        {
            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine()!);

            var history = await service.GetMedicalHistoryAsync(patientId);

            Console.WriteLine("\n--- Medical History ---");

            foreach (var record in history)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Visit Date: {record.VisitDate}");
                Console.WriteLine($"Diagnosis: {record.Diagnosis}");
                Console.WriteLine($"Prescription Summary: {record.Prescription}");
                Console.WriteLine($"Notes: {record.Notes}");
                Console.WriteLine($"Medicine: {record.MedicineName}");
                Console.WriteLine($"Dosage: {record.Dosage}");
                Console.WriteLine($"Duration: {record.Duration}");
            }

            if (history.Count == 0)
            {
                Console.WriteLine("No medical history found.");
            }
        }
    }
}