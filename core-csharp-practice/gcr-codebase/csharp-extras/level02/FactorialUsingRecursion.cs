using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02
{
    internal class FactorialUsingRecursion
    {
        // input the user number
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(n));
        }
        // recursive function to calculate factorial
        static int Fact(int n)
        {
            // base condition
            if (n <= 1)
            {
                return 1;
            }
            // calling itself
            return n * Fact(n - 1);
        }
    }
}
