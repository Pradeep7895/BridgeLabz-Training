using Newtonsoft.Json.Linq;
using System;

class Program
{
    static void Main()
    {
        JObject obj1 = JObject.Parse(@"{
            'name': 'Alice',
            'age': 25
        }");

        JObject obj2 = JObject.Parse(@"{
            'email': 'pradeep@gmail.com',
            'city' : 'Mathura'
        }");

        obj1.Merge(obj2);

        Console.WriteLine(obj1.ToString());
    }
}
