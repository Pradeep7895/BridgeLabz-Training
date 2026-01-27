using System;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    public class Employee
    {
        private int id;
        public string Name;

        public Employee() { }

        public Employee(int id)
        {
            this.id = id;
        }

        public void Display()
        {
            Console.WriteLine("Employee details");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter class name: ");
            string className = Console.ReadLine();

            Type type = Type.GetType(className);

            if (type == null)
            {
                Console.WriteLine("Class not found");
                return;
            }

            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in type.GetMethods(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                Console.WriteLine(ctor.ToString());
            }
        }
    }
}


