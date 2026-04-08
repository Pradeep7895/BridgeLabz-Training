using Newtonsoft.Json;
using System;
using System.Collections.Generic;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Salary = 60000 }
        };

        string report = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine(report);
    }
}
