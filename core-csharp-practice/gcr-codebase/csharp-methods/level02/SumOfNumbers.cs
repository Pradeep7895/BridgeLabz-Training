using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class SumOfNumbers
    {

        // Recursive method to calculate sum
        static int RecurSum(int n)
        {
            if (n == 0)
                return 0;

            return n + RecurSum(n - 1);
        }

        // Method to calculate sum using formula
        static int FormulaSum(int n)
        {
            return n * (n + 1) / 2;
        }

        static void Main()
        {
            // Take input
            Console.Write("Enter a natural number: ");
            int n = int.Parse(Console.ReadLine()!);

            // Validate number
            if (n < 0)
            {
                Console.WriteLine("Not a natural number");
                return;
            }

            // Calculate sums
            int sum1 = RecurSum(n);
            int sum2 = FormulaSum(n);

            // Display results
            Console.WriteLine("Recursive Sum = " + sum1);
            Console.WriteLine("Formula Sum = " + sum2);

            // Compare results
            Console.WriteLine(sum1 == sum2
                ? "Both sums are equal"
                : "Results are different");
        }
    }
}
