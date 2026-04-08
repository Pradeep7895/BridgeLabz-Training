using System;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class TaskInfoAttribute : Attribute
    {
        public string Priority { get; }
        public string AssignedTo { get; }

        public TaskInfoAttribute(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    class TaskManager
    {
        [TaskInfo("HIGH", "Alice")]
        public void CompleteTask() { }
    }
    class Program
    {
        static void Main()
        {
            MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
            var attr = method.GetCustomAttribute<TaskInfoAttribute>();

            Console.WriteLine($"Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
        }
    }

}
