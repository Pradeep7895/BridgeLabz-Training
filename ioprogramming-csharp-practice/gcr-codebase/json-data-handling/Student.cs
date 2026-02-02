using Newtonsoft.Json;
using System;

class Student
{
    static void Main()
    {
        var student = new
        {
            name = "Pradeep",
            age = 22,
            subjects = new string[] { "C#", "DBMS", "DSA" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}
