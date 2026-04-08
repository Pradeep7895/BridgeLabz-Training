using System;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute : Attribute
    {
    }

    public class Service
    {
        [LogExecutionTime]
        public void FastOperation()
        {
            Thread.Sleep(300); // 300 ms
        }

        [LogExecutionTime]
        public void SlowOperation()
        {
            Thread.Sleep(1000); // 1 second
        }

        public void NormalOperation()
        {
            Thread.Sleep(500); // No attribute → ignored
        }
    }

    class Program
    {
        static void Main()
        {
            Service service = new Service();
            Type type = typeof(Service);

            Console.WriteLine("Execution Time Report:\n");

            foreach (MethodInfo method in type.GetMethods(
                         BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                // Check if method has LogExecutionTime attribute
                var attribute = method.GetCustomAttribute<LogExecutionTimeAttribute>();

                if (attribute != null)
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();

                    // Invoke the method
                    method.Invoke(service, null);

                    stopwatch.Stop();

                    Console.WriteLine(
                        $"Method: {method.Name} | Time Taken: {stopwatch.ElapsedMilliseconds} ms");
                }
            }
        }
    }
}
