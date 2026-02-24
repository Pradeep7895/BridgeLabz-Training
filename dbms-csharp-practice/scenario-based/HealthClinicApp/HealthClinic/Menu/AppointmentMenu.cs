using HealthClinic.Models;
using HealthClinic.Services;

namespace HealthClinic.Menu
{
    public class AppointmentMenu
    {
        private readonly AppointmentService service = new();

        public async Task ShowAsync()
        {
            while (true)
            {
                Console.WriteLine("\n--- Appointment Management ---");
                Console.WriteLine("1. Book Appointment");
                Console.WriteLine("2. Check Doctor Availability");
                Console.WriteLine("3. Cancel Appointment");
                Console.WriteLine("4. Reschedule Appointment");
                Console.WriteLine("5. View Daily Schedule");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        await BookAsync();
                        break;
                    case 2:
                        await CheckAvailabilityAsync();
                        break;
                    case 3:
                        await CancelAsync();
                        break;
                    case 4:
                        await RescheduleAsync();
                        break;
                    case 5:
                        await ViewScheduleAsync();
                        break;
                    case 6:
                        return;
                }
            }
        }

        private async Task BookAsync()
        {
            var appointment = new Appointment();

            Console.Write("Patient ID: ");
            appointment.PatientId = int.Parse(Console.ReadLine()!);

            Console.Write("Doctor ID: ");
            appointment.DoctorId = int.Parse(Console.ReadLine()!);

            Console.Write("Date (yyyy-mm-dd): ");
            appointment.AppointmentDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Time (HH:mm): ");
            appointment.AppointmentTime = TimeSpan.Parse(Console.ReadLine()!);

            await service.BookAppointmentAsync(appointment);
            Console.WriteLine("Appointment booked successfully!");
        }

        private async Task CheckAvailabilityAsync()
        {
            Console.Write("Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine()!);

            Console.Write("Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine()!);

            await service.CheckDoctorAvailabilityAsync(doctorId, date);
        }

        private async Task CancelAsync()
        {
            Console.Write("Appointment ID: ");
            int id = int.Parse(Console.ReadLine()!);

            await service.CancelAppointmentAsync(id);
            Console.WriteLine("Appointment cancelled successfully!");
        }

        private async Task RescheduleAsync()
        {
            Console.Write("Appointment ID: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("New Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine()!);

            Console.Write("New Time (HH:mm): ");
            TimeSpan time = TimeSpan.Parse(Console.ReadLine()!);

            Console.Write("New Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine()!);

            await service.RescheduleAppointmentAsync(id, date, time, doctorId);

            Console.WriteLine("Appointment rescheduled successfully!");
        }

        private async Task ViewScheduleAsync()
        {
            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine()!);

            var schedule = await service.GetDailyScheduleAsync(date);

            foreach (var s in schedule)
            {
                Console.WriteLine($"{s.AppointmentTime} | {s.PatientName} | {s.DoctorName} | {s.Status}");
            }
        }
    }
}