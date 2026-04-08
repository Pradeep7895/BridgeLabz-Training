using Microsoft.Data.SqlClient;

namespace HealthClinic.Connection
{
    public static class DbConnectionFactory
    {
        private static readonly string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}