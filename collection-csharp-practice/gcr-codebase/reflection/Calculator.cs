using System;
using System.Reflection;


namespace Collections.collection_csharp_practice.gcr_codebase.reflection
{
    class Calculator
    {
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            Type type = typeof(Calculator);

            MethodInfo method = type.GetMethod(
                "Multiply",
                BindingFlags.NonPublic | BindingFlags.Instance);

            int result = (int)method.Invoke(calc, new object[] { 5, 4 });

            Console.WriteLine("Multiplication Result: " + result);
        }
    }
}
