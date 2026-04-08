using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class QuotientAndRemainder
    {
        // find quotient and remainder
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {

            int quotient = number / divisor;   // Division
            int remainder = number % divisor;  // Modulus

            return new int[] { quotient, remainder };
        }

        static void Main()
        {
            // Input values
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            // Call method
            int[] result = FindRemainderAndQuotient(number, divisor);


            // Print results
            Console.WriteLine("Quotient = " + result[0]);
            Console.WriteLine("Remainder = " + result[1]);
        }
    }
}
