using System;
using System.Collections.Generic;

using System.Reflection;



namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    public class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
    }

    //object mapping
    public static class ObjectMapper
    {
        public static T ToObject<T>(Dictionary<string, object> properties)
            where T : new()
        {
            T obj = new T();
            Type type = typeof(T);

            foreach (var item in properties)
            {
                FieldInfo field = type.GetField(item.Key);
                if (field != null)
                {
                    field.SetValue(obj, item.Value);
                }
            }
            return obj;
        }
    }

    class Program
    {
        static void Main()
        {
            var data = new Dictionary<string, object>
        {
            { "Id", 1 },
            { "Name", "Pradeep" },
            { "Salary", 50000.0 }
        };

            Employee emp = ObjectMapper.ToObject<Employee>(data);
            Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Salary}");
        }
    }

}
