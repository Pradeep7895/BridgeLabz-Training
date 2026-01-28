using System;
using System.Diagnostics;
using System.Reflection;

namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    public class Worker
    {
        public void FastTask()
        {
            Thread.Sleep(200); // simulate fast work
        }

        public void MediumTask()
        {
            Thread.Sleep(500); // simulate medium work
        }

        public void SlowTask()
        {
            Thread.Sleep(1000); // simulate slow work
        }
    }

    //Create Execution Timer Using Reflection
    public static class ExecutionTimer
    {
        public static void MeasureExecutionTime(object obj)
        {
            Type type = obj.GetType();

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.DeclaredOnly);

            Console.WriteLine("Method Execution Time Report:\n");

            foreach (MethodInfo method in methods)
            {
                // Skip methods with parameters
                if (method.GetParameters().Length > 0)
                    continue;

                Stopwatch stopwatch = Stopwatch.StartNew();

                method.Invoke(obj, null);

                stopwatch.Stop();

                Console.WriteLine(
                    $"{method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Worker worker = new Worker();

            ExecutionTimer.MeasureExecutionTime(worker);
        }
    }

}
