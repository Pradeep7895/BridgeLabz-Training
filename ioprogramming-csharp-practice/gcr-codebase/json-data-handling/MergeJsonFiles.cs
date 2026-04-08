using Newtonsoft.Json.Linq;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        JObject obj1 = JObject.Parse(File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\file1.json"));
        JObject obj2 = JObject.Parse(File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\file2.json"));

        obj1.Merge(obj2);

        Console.WriteLine(obj1.ToString());
    }
}
