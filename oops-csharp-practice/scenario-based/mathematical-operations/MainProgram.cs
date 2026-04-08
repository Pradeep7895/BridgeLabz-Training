using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.oops_csharp_practice.scenario_based.mathematical_operations;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.mathematical_operations
{
    internal class MainProgram
    {
        static void Main()
        {
            // Factorial Tests
            Console.WriteLine("Factorial Tests:");
            Console.WriteLine("8! = " + MathUtility.Factorial(8));
            Console.WriteLine("0! = " + MathUtility.Factorial(0));

            // Prime Tests
            Console.WriteLine("\nPrime Tests:");
            Console.WriteLine("Is 13 Prime? " + MathUtility.IsPrime(13));
            Console.WriteLine("Is 1 Prime? " + MathUtility.IsPrime(1));
            Console.WriteLine("Is -5 Prime? " + MathUtility.IsPrime(-5));

            // GCD Tests
            Console.WriteLine("\nGCD Tests:");
            Console.WriteLine("GCD(48, 16) = " + MathUtility.GCD(48, 16));
            Console.WriteLine("GCD(-12, 4) = " + MathUtility.GCD(-12, 4));

            // Fibonacci Tests
            Console.WriteLine("\nFibonacci Tests:");
            Console.WriteLine("Fibonacci(0) = " + MathUtility.Fibonacci(0));
            Console.WriteLine("Fibonacci(1) = " + MathUtility.Fibonacci(1));
            Console.WriteLine("Fibonacci(11) = " + MathUtility.Fibonacci(7));

            Console.WriteLine("\n Successfully executed all cases.");
        }

    }
}

    