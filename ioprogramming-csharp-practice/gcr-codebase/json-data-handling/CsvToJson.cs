using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\data.csv");
        var list = new List<Dictionary<string, string>>();

        string[] headers = lines[0].Split(',');

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            var obj = new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                obj[headers[j]] = values[j];
            }

            list.Add(obj);
        }

        string json = JsonConvert.SerializeObject(list, Formatting.Indented);
        Console.WriteLine(json);
    }
}
