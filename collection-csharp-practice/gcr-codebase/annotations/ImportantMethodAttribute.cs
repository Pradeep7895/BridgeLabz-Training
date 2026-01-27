using System;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }

    public class SampleService
    {
        [ImportantMethod] // default level = HIGH
        public void SaveData()
        {
            Console.WriteLine("Saving data...");
        }

        [ImportantMethod("LOW")]
        public void LogData()
        {
            Console.WriteLine("Logging data...");
        }
    }
    class Program
    {
        static void Main()
        {
            Type type = typeof(SampleService);
            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Console.WriteLine("Important Methods Found:\n");

            foreach (MethodInfo method in methods)
            {
                ImportantMethodAttribute attr =
                    method.GetCustomAttribute<ImportantMethodAttribute>();

                if (attr != null)
                {
                    Console.WriteLine(
                        $"Method Name: {method.Name}, Importance Level: {attr.Level}");
                }
            }
        }
    }


}


