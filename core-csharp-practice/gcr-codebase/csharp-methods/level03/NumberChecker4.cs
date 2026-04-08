using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class NumberChecker4
    {
        //check for prime no.
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        //check for Neon number
        static bool IsNeon(int n)
        {
            int square = n * n;
            int sum = 0;

            // Find sum of digits of the square
            while (square > 0)
            {
                sum += square % 10;
                square /= 10;
            }

            return sum == n;
        }

        // Method for Spy number
        static bool IsSpy(int n)
        {
            int sum = 0;
            int product = 1;

            while (n > 0)
            {
                int d = n % 10;
                sum += d;
                product *= d;
                n /= 10;
            }

           
            return sum == product;
        }

        // Method for Automorphic number
        static bool IsAutomorphic(int n)
        {
            return (n * n).ToString().EndsWith(n.ToString());
        }

        // Method for Buzz number
        static bool IsBuzz(int n)
        {
            return n % 7 == 0 || n % 10 == 7;
        }

        static void Main()
        {
            // Read number input from the user
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            // Display results
            Console.WriteLine("Prime: " + IsPrime(n));
            Console.WriteLine("Neon: " + IsNeon(n));
            Console.WriteLine("Spy: " + IsSpy(n));
            Console.WriteLine("Automorphic: " + IsAutomorphic(n));
            Console.WriteLine("Buzz: " + IsBuzz(n));
        }

    }

}

