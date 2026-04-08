using Newtonsoft.Json.Linq;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\User.json");
        JObject obj = JObject.Parse(json);

        foreach (var property in obj.Properties())
        {
            Console.WriteLine($"{property.Name} : {property.Value}");
        }
    }
}
