using Newtonsoft.Json.Linq;
using System;
using System.IO;

class ReadAndExtract
{
    static void Main()
    {
        string json = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\User.json");
        JObject obj = JObject.Parse(json);

        Console.WriteLine("Name: " + obj["name"]);
        Console.WriteLine("Email: " + obj["email"]);
    }
}
