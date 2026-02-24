namespace HealthClinic.Exceptions
{
    public class ValidationException : ClinicException
    {
        public ValidationException(string message) : base(message) { }
    }
}