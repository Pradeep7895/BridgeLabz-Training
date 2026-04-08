using HealthClinic.Models;

namespace HealthClinic.Interfaces
{
    public interface IAppointmentService
    {
        Task BookAppointmentAsync(Appointment appointment);
        Task CheckDoctorAvailabilityAsync(int doctorId, DateTime date);
        Task CancelAppointmentAsync(int appointmentId);
        Task RescheduleAppointmentAsync(int appointmentId, DateTime newDate, TimeSpan newTime, int newDoctorId);
        Task<List<DailyScheduleDTO>> GetDailyScheduleAsync(DateTime date);
    }
}