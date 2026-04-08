using System;
using System.Reflection;

//Access and Modify Private Static Fields

namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    class Configuration
    {
        private static string API_KEY = "OLD_KEY";

        public static void ShowKey()
        {
            Console.WriteLine("API KEY: " + API_KEY);
        }
    }

    //reflection code to modify static field
    class Program
    {
        static void Main()
        {
            Type type = typeof(Configuration);

            FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            // Print old value
            Configuration.ShowKey();

            // Modify static field
            field.SetValue(null, "NEW_SECURE_KEY");

            // Print new value
            Configuration.ShowKey();
        }
    }
}
