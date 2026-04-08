using Newtonsoft.Json.Linq;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\users.json");
        JArray users = JArray.Parse(json);

        Console.WriteLine("Users with age > 25:");

        foreach (var user in users)
        {
            if ((int)user["age"] > 25)
            {
                Console.WriteLine(user["name"] + " - " + user["age"]);
            }
        }
    }
}
