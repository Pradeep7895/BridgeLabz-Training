using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.mathematical_operations
{
    internal class MathUtility
    {
        // 1. Factorial of a number
        public static long Factorial(int n)
        {
            // Handle edge case
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers");

            
            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }

        // 2. Check if a number is prime
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            // Check for factors from 2 to sqrt(n)
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // 3. Find GCD of two numbers 
        public static int GCD(int a, int b)
        {
            // Handle negative numbers
            a = Math.Abs(a);
            b = Math.Abs(b);
            // Euclidean algorithm
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

        // 4. Find nth Fibonacci number
        public static long Fibonacci(int n)
        {
            // Handle edge case
            if (n < 0)
                throw new ArgumentException("Fibonacci is not defined for negative numbers");
            // Base cases
            if (n == 0) return 0;
            if (n == 1) return 1;

            long a = 0, b = 1, c = 0;
            // compute Fibonacci numbers
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

    }
}
    
