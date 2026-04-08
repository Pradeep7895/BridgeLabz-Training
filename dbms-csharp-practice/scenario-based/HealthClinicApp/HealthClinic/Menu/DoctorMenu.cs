using HealthClinic.Models;
using HealthClinic.Services;

namespace HealthClinic.Menu
{
    public class DoctorMenu
    {
        private readonly DoctorService service = new();

        public async Task ShowAsync()
        {
            while (true)
            {
                Console.WriteLine("\n--- Doctor Management ---");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Update Doctor Specialty");
                Console.WriteLine("3. View Doctors by Specialty");
                Console.WriteLine("4. Deactivate Doctor");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        await AddDoctorAsync();
                        break;
                    case 2:
                        await UpdateSpecialtyAsync();
                        break;
                    case 3:
                        await ViewBySpecialtyAsync();
                        break;
                    case 4:
                        await DeactivateAsync();
                        break;
                    case 5:
                        return;
                }
            }
        }

        private async Task AddDoctorAsync()
        {
            await service.DisplaySpecialtiesAsync();

            var doctor = new Doctor();

            Console.Write("Name: ");
            doctor.FullName = Console.ReadLine();

            Console.Write("Specialty ID: ");
            doctor.SpecialtyId = int.Parse(Console.ReadLine()!);

            Console.Write("Phone: ");
            doctor.Phone = Console.ReadLine();

            Console.Write("Consultation Fee: ");
            doctor.ConsultationFee = decimal.Parse(Console.ReadLine()!);

            await service.AddDoctorAsync(doctor);

            Console.WriteLine("Doctor added successfully!");
        }

        private async Task UpdateSpecialtyAsync()
        {
            await service.DisplaySpecialtiesAsync();

            Console.Write("Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine()!);

            Console.Write("New Specialty ID: ");
            int specialtyId = int.Parse(Console.ReadLine()!);

            await service.UpdateDoctorSpecialtyAsync(doctorId, specialtyId);

            Console.WriteLine("Doctor specialty updated!");
        }

        private async Task ViewBySpecialtyAsync()
        {
            Console.Write("Enter Specialty Name: ");
            string name = Console.ReadLine()!;

            var doctors = await service.GetDoctorsBySpecialtyAsync(name);

            foreach (var d in doctors)
            {
                Console.WriteLine($"{d.DoctorId} | {d.FullName} | {d.Phone} | Fee: {d.ConsultationFee}");
            }
        }

        private async Task DeactivateAsync()
        {
            Console.Write("Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine()!);

            await service.DeactivateDoctorAsync(doctorId);

            Console.WriteLine("Doctor deactivated successfully!");
        }
    }
}