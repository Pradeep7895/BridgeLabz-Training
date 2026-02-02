using Newtonsoft.Json;
using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 22 },
            new Student { Name = "Bob", Age = 28 }
        };

        string json = JsonConvert.SerializeObject(students, Formatting.Indented);
        Console.WriteLine(json);
    }
}
