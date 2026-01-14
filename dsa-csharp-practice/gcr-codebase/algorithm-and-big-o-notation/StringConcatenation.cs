using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.algorithm_and_big_o_notation
{
    internal class StringConcatenation
    {
        // Using normal string (O(N^2))
        static void UsingString(int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += "a";
            }
        }

        // Using StringBuilder (O(N))
        static void UsingStringBuilder(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append("a");
            }
        }

        static void Main()
        {
            int[] operationCounts = { 1000, 10000, 1000000 };

            foreach (int n in operationCounts)
            {
                Console.WriteLine($"\nOperations Count: {n}");

                // String concatenation
                Stopwatch sw = Stopwatch.StartNew();
                UsingString(n);
                sw.Stop();
                Console.WriteLine($"String Time: {sw.ElapsedMilliseconds} ms");

                // StringBuilder concatenation
                sw.Restart();
                UsingStringBuilder(n);
                sw.Stop();
                Console.WriteLine($"StringBuilder Time: {sw.ElapsedMilliseconds} ms");
            }
        }

    }
}

   