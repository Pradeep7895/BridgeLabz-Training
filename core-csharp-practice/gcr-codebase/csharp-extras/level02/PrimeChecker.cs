using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02
{
    internal class PrimeChecker
    {
        
        static void Main(string[] args)
        {
            // input the user number
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        // checking is the prime
        static bool IsPrime(int n)
        {
            // base condition
            if (n <= 1)
            {
                return false;
            }
            // checking for factors
            for (int i = 2; i * i <= n; i++)
            {
                // if factor found
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
