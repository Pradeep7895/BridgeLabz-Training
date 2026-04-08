using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Collections.ioprogramming_csharp_practice.gcr_codebase.csv_data_handling
{
    class Employee
    {
        public int ID;
        public string Name;
        public string Department;
        public double Salary;
    }
    class SortCSVFile
    {
        static void Main(string[] args)
        {
            string filePath = "D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";
            List<Employee> employees = new List<Employee>();

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

                        employees.Add(new Employee
                        {
                            ID = int.Parse(data[0]),
                            Name = data[1],
                            Department = data[2],
                            Salary = double.Parse(data[3])
                        });
                    }
                }

                // Sort by salary descending
                var topEmployees = employees.OrderByDescending(e => e.Salary)
                    .Take(5);

                Console.WriteLine("Top 5 Highest-Paid Employees:\n");

                foreach (var emp in topEmployees)
                {
                    Console.WriteLine($"ID : {emp.ID}");
                    Console.WriteLine($"Name : {emp.Name}");
                    Console.WriteLine($"Department : {emp.Department}");
                    Console.WriteLine($"Salary  : {emp.Salary}");
                    Console.WriteLine("-----------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}




