using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            // input the number
            int n = Convert.ToInt32(Console.ReadLine());
            // print the fibonacci series till that number
            Fib(n);
        }
        static void Fib(int n)
        {
            // printing the fib till that number
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                // print the current number
                Console.WriteLine(a);
                // calculate the next number
                int c = a + b;
                // update the values
                a = b;
                
                b = c;
            }
        }
    }
}
