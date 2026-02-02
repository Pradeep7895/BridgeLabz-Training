using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.IO;

class Validate
{
    static void Main()
    {
        string schemaText = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\Schema.json");
        string jsonText = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\Info.json");

        JSchema schema = JSchema.Parse(schemaText);
        JObject obj = JObject.Parse(jsonText);

        if (obj.IsValid(schema))
            Console.WriteLine("JSON is valid");
        else
            Console.WriteLine("JSON is invalid");
    }
}
