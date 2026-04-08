using System;
using System.IO;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;

                    // Skip header
                    reader.ReadLine();

                    Console.WriteLine("Students scoring more than 80 marks:\n");

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        int marks = int.Parse(data[3]);

                        if (marks > 80)
                        {
                            Console.WriteLine($"ID    : {data[0]}");
                            Console.WriteLine($"Name  : {data[1]}");
                            Console.WriteLine($"Marks : {marks}");
                            Console.WriteLine("-----------------------");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}


