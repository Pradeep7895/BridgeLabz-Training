using System;
using System.IO;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class ReadStudentCSV
    {
        static void Main()
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Skip header line
                    reader.ReadLine();

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        int id = int.Parse(data[0]);
                        string name = data[1];
                        int age = int.Parse(data[2]);
                        int marks = int.Parse(data[3]);

                        Console.WriteLine("Student Details:");
                        Console.WriteLine($"ID    : {id}");
                        Console.WriteLine($"Name  : {name}");
                        Console.WriteLine($"Age   : {age}");
                        Console.WriteLine($"Marks : {marks}");
                        Console.WriteLine("----------------------");
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



