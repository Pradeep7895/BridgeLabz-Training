using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class SumOfNumbers
    {

        //calculate sum using loop
        static int Sum(int n)
        {
            int sum = 0;

            // Loop from 1 to n
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }
        static void Main()
        {
            // Take input
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            // Display output
            Console.WriteLine("Sum = " + Sum(n));
        }
    }
}
