using System;
using System.IO;
using System.Collections.Generic;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class MergeTwoCSV
    {
        static void Main(string[] args)
        {
            string file1 = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students1.csv";
            string file2 = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students2.csv";
            string outputFile = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\MergedStudents.csv";

            // Dictionary: ID -> (Name, Age)
            Dictionary<int, (string Name, int Age)> studentInfo =
                new Dictionary<int, (string, int)>();

            try
            {
                // Step 1: Read students1.csv
                using (StreamReader reader1 = new StreamReader(file1))
                {
                    string? line;
                    reader1.ReadLine(); // skip header

                    while ((line = reader1.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        int id = int.Parse(data[0]);
                        string name = data[1];
                        int age = int.Parse(data[2]);

                        studentInfo[id] = (name, age);
                    }
                }

                // Step 2: Read students2.csv and merge
                using (StreamReader reader2 = new StreamReader(file2))
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    // Write header to merged file
                    writer.WriteLine("ID,Name,Age,Marks,Grade");

                    string? line;
                    reader2.ReadLine(); // skip header

                    while ((line = reader2.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        int id = int.Parse(data[0]);
                        int marks = int.Parse(data[1]);
                        string grade = data[2];

                        if (studentInfo.ContainsKey(id))
                        {
                            var info = studentInfo[id];
                            writer.WriteLine($"{id},{info.Name},{info.Age},{marks},{grade}");
                        }
                    }
                }

                Console.WriteLine("CSV files merged successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}



    