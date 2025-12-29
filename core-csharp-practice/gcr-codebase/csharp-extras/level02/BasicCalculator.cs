using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02

{
    internal class BasicCalculator
    {
        static void Main(string[] args)
        {
            //taking input
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            string opeartor = Console.ReadLine();

            if (opeartor == "+")
            {
                Console.WriteLine(Add(num1, num2));
            }
            else if (opeartor == "-")
            {
                Console.WriteLine(Sub(num1, num2));
            }
            else if (opeartor == "*")
            {
                Console.WriteLine(Mul(num1, num2));
            }
            else
            {
                Console.WriteLine(Div(num1, num2));
            }
        }
        //method for each opreations
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
