using System;
using System.IO;
using System.Collections.Generic;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"ID={ID}, Name={Name}, Age={Age}, Marks={Marks}";
        }
    }

    class ConvertCSVToObject
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";
            List<Student> students = new List<Student>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;

                    // Skip header
                    reader.ReadLine();

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        Student student = new Student
                        {
                            ID = int.Parse(data[0]),
                            Name = data[1],
                            Age = int.Parse(data[2]),
                            Marks = int.Parse(data[3])
                        };

                        students.Add(student);
                    }
                }

                Console.WriteLine("Student Records:\n");

                foreach (Student s in students)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}



    