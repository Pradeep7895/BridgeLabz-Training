using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("D:\\Collections\\Collections\\ioprogramming-csharp-practice\\gcr-codebase\\json-data-handling\\Info.json");

        XmlDocument xml = JsonConvert.DeserializeXmlNode(json, "Root");

        Console.WriteLine(xml.OuterXml);
    }
}
