using System;
using System.IO;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";
            string outputFile = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\UpdatedEmployees.csv";

            try
            {
                using (StreamReader reader = new StreamReader(inputFile))
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    string? line;

                    // Read and write header
                    line = reader.ReadLine();
                    writer.WriteLine(line);

                    // Process records
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        string department = data[2];
                        double salary = double.Parse(data[3]);

                        // Increase salary by 10% for IT department
                        if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            salary = salary + (salary * 0.10);
                        }

                        // Write updated record
                        writer.WriteLine($"{data[0]},{data[1]},{department},{salary}");
                    }
                }

                Console.WriteLine("CSV file updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}


