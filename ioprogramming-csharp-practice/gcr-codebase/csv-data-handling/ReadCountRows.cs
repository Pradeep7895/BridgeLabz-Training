using System;
using System.IO;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";
            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;

                    // Skip header row
                    reader.ReadLine();

                    // Count remaining rows
                    while ((line = reader.ReadLine()) != null)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Total number of records (excluding header): " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}



