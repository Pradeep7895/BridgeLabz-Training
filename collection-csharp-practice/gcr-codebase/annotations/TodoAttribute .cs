using System;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        // Priority has default value medium
        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    public class ProjectTasks
    {
        [Todo("Fix login validation bug", "Alice", "HIGH")]
        [Todo("Add unit tests for login", "Bob")]
        public void LoginFeature()
        {
            Console.WriteLine("Login feature");
        }

        [Todo("Optimize database queries", "Charlie", "HIGH")]
        public void DataProcessing()
        {
            Console.WriteLine("Data processing");
        }

        [Todo("Improve UI styling", "Diana", "LOW")]
        public void UserInterface()
        {
            Console.WriteLine("User interface");
        }
    }

    class Program
    {
        static void Main()
        {
            Type type = typeof(ProjectTasks);

            Console.WriteLine("Pending Tasks:\n");

            foreach (MethodInfo method in type.GetMethods(
                         BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                TodoAttribute[] todos =
                    (TodoAttribute[])method.GetCustomAttributes(typeof(TodoAttribute), false);

                foreach (TodoAttribute todo in todos)
                {
                    Console.WriteLine($"Method: {method.Name}");
                    Console.WriteLine($"  Task       : {todo.Task}");
                    Console.WriteLine($"  Assigned To: {todo.AssignedTo}");
                    Console.WriteLine($"  Priority   : {todo.Priority}");
                    Console.WriteLine();
                }
            }
        }
    }
}
