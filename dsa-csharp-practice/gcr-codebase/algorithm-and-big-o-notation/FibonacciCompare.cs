using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.algorithm_and_big_o_notation
{
    internal class FibonacciCompare
    {
        // Recursive Fibonacci (O(2^N))
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // Iterative Fibonacci (O(N))
        public static int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }

        static void Main()
        {
            int[] testValues = { 10, 30, 50 };

            foreach (int n in testValues)
            {
                Console.WriteLine($"\nFibonacci({n})");

                // Iterative approach timing
                Stopwatch sw = Stopwatch.StartNew();
                int iterResult = FibonacciIterative(n);
                sw.Stop();
                Console.WriteLine($"Iterative Result: {iterResult}");
                Console.WriteLine($"Iterative Time: {sw.ElapsedMilliseconds} ms");

                // Recursive approach timing 
                if (n <= 30)
                {
                    sw.Restart();
                    int recResult = FibonacciRecursive(n);
                    sw.Stop();
                    Console.WriteLine($"Recursive Result: {recResult}");
                    Console.WriteLine($"Recursive Time: {sw.ElapsedMilliseconds} ms");
                }
                else
                {
                    Console.WriteLine("Recursive Result: Skipped (Unfeasible for large N)");
                }
            }
        }

    }
}

   