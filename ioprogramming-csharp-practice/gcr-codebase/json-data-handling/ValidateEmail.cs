using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string schemaText = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\emailSchema.json");
        string jsonText = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\userEmail.json");

        JSchema schema = JSchema.Parse(schemaText);
        JObject obj = JObject.Parse(jsonText);

        Console.WriteLine(obj.IsValid(schema)
            ? "Valid Email"
            : "Invalid Email");
    }
}
