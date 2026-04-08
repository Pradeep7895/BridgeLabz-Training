using System;
using System.IO;
using Microsoft.Data.SqlClient;


namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class GenerateCSVReport
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Data Source=.;Initial Catalog=CompanyDB;Integrated Security=True";

            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            string csvFilePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\EmployeeReport.csv";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (StreamWriter writer = new StreamWriter(csvFilePath))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Write CSV header
                        writer.WriteLine("Employee ID,Name,Department,Salary");

                        // Write rows
                        while (reader.Read())
                        {
                            writer.WriteLine(
                                $"{reader["EmployeeID"]}," +
                                $"{reader["Name"]}," +
                                $"{reader["Department"]}," +
                                $"{reader["Salary"]}"
                            );
                        }
                    }
                }

                Console.WriteLine("CSV report generated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
