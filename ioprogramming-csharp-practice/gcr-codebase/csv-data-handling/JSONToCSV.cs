using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    internal class JSONToCSV
    {

        static void Main()
        {
            JsonToCsv("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.json", 
                "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv");

            CsvToJson("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv",
                "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\StudentsConverted.json");
        }

        static void JsonToCsv(string jsonPath, string csvPath)
        {
            string jsonData = File.ReadAllText(jsonPath);

            List<Student> students =
                JsonSerializer.Deserialize<List<Student>>(jsonData);

            using (StreamWriter writer = new StreamWriter(csvPath))
            {
                // Write CSV header
                writer.WriteLine("ID,Name,Age,Marks");

                foreach (var s in students)
                {
                    writer.WriteLine($"{s.ID},{s.Name},{s.Age},{s.Marks}");
                }
            }

            Console.WriteLine("JSON converted to CSV successfully!");
        }

        static void CsvToJson(string csvPath, string jsonPath)
        {
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(csvPath))
            {
                string? line;

                // Skip header
                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    students.Add(new Student
                    {
                        ID = int.Parse(data[0]),
                        Name = data[1],
                        Age = int.Parse(data[2]),
                        Marks = int.Parse(data[3])
                    });
                }
            }

            string jsonOutput = JsonSerializer.Serialize(
                students,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(jsonPath, jsonOutput);

            Console.WriteLine("CSV converted back to JSON successfully!");
        }
    }
}


