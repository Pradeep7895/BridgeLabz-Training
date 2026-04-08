using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
    internal class EmployeeSerialization
    {
        static string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
        static string filePath = basePath +  "employees.json";

        static void Main()
        {
            try
            {
                // Create list of employees
                List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 60000 },
                new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 50000 },
                new Employee { Id = 3, Name = "Rahul", Department = "Finance", Salary = 55000 }
            };

                // Serialize employee list
                SerializeEmployees(employees);

                // Deserialize and display employees
                DeserializeEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }

        // Serialize employee list to file
        static void SerializeEmployees(List<Employee> employees)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize(employees, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(filePath, jsonData);
                Console.WriteLine("Employee data serialized successfully.\n");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Serialization I/O Error: " + ex.Message);
            }
        }

        // Deserialize employee list from file
        static void DeserializeEmployees()
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonData);

                Console.WriteLine("Deserialized Employee Data:");
              

                foreach (Employee emp in employees)
                {
                    Console.WriteLine($"ID: {emp.Id}");
                    Console.WriteLine($"Name: {emp.Name}");
                    Console.WriteLine($"Department: {emp.Department}");
                    Console.WriteLine($"Salary: {emp.Salary}");
                    Console.WriteLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Deserialization I/O Error: " + ex.Message);
            }
        }
    }
}




   
