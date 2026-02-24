namespace HealthClinic.Exceptions
{
    public class NotFoundException : ClinicException
    {
        public NotFoundException(string message) : base(message) { }
    }
}