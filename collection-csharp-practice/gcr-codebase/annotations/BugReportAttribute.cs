using System;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReportAttribute : Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }

    class Service
    {
        [BugReport("Null reference issue")]
        [BugReport("Performance issue")]
        public void Process() { }
    }

    class Program
    {
        static void Main()
        {
            var bugs = typeof(Service).GetMethod("Process")
                .GetCustomAttributes<BugReportAttribute>();

            foreach (var bug in bugs)
            {
                Console.WriteLine(bug.Description);
            }
        }
    }
}
