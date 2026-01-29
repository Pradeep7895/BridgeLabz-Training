using System;
using System.IO;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write header
                    writer.WriteLine("ID,Name,Department,Salary");

                    // Write employee records
                    writer.WriteLine("101,Rahul,Engineering,60000");
                    writer.WriteLine("102,Anita,HR,50000");
                    writer.WriteLine("103,Vikram,Marketing,55000");
                    writer.WriteLine("104,Priya,Finance,62000");
                    writer.WriteLine("105,Karan,Sales,58000");
                }

                Console.WriteLine("CSV file created and data written successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}



