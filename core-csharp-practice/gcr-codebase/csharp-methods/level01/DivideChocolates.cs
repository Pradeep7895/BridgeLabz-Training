using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class DivideChocolates
    {
        // Method to calculate chocolates
        static int[] FindCholocatesPerChild(int n, int m)
        {
            int eachChild = n / m;
            int remaining = n % m;

            return new int[] { eachChild, remaining };
        }
        static void Main()
        {
            // Input chocolates
            Console.Write("Enter number of chocolates: ");
            int n = int.Parse(Console.ReadLine());

            // Input children
            Console.Write("Enter number of children: ");
            int m = int.Parse(Console.ReadLine());

            // Call method
            int[] result = FindCholocatesPerChild(n, m);

            // Display output
            Console.WriteLine("Each child gets = " + result[0]);
            Console.WriteLine("Remaining chocolates = " + result[1]);
        }
    }
}
