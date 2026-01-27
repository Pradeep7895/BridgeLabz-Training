using System;
using System.Collections.Generic;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheResultAttribute : Attribute
    {
    }

    public class MathService
    {
        [CacheResult]
        public int Square(int number)
        {
            Console.WriteLine("Computing square...");
            Thread.Sleep(2000); 
            return number * number;
        }
    }

    public static class CacheExecutor
    {
        // Cache: MethodName + Input → Result
        private static Dictionary<string, object> cache = new Dictionary<string, object>();

        public static object Execute(object target, string methodName, params object[] parameters)
        {
            Type type = target.GetType();
            MethodInfo method = type.GetMethod(methodName);

            // Check if method has CacheResult attribute
            var attribute = method.GetCustomAttribute<CacheResultAttribute>();

            string cacheKey = $"{methodName}_{string.Join("_", parameters)}";

            // If caching enabled and value exists → return cached result
            if (attribute != null && cache.ContainsKey(cacheKey))
            {
                Console.WriteLine("Returning cached result...");
                return cache[cacheKey];
            }

            // Otherwise invoke method
            object result = method.Invoke(target, parameters);

            // Store result in cache if attribute present
            if (attribute != null)
            {
                cache[cacheKey] = result;
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            MathService service = new MathService();

            Console.WriteLine("First call:");
            var result1 = CacheExecutor.Execute(service, "Square", 5);
            Console.WriteLine("Result: " + result1);

            Console.WriteLine("\nSecond call (same input):");
            var result2 = CacheExecutor.Execute(service, "Square", 5);
            Console.WriteLine("Result: " + result2);

            Console.WriteLine("\nThird call (different input):");
            var result3 = CacheExecutor.Execute(service, "Square", 6);
            Console.WriteLine("Result: " + result3);
        }
    }   
}
   