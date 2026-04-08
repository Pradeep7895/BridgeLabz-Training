using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.extras.level02
{
    internal class MaximumOfThree
    {
        //function to take input
        static int TakeInput(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        //function to find maximum of three numbers
        static int Maximun(int a, int b, int c)
        {
            int max = a;
            if(b > max)
                max = b;
            if(c > max)
                max = c;

            return max;
        }
        static void Main()
        {
            //taking inputs
            int num1 = TakeInput("Enter first number: ");
            int num2 = TakeInput("Enter second number: ");
            int num3 = TakeInput("Enter third number: ");

            //finding maximum
            int maximum = Maximun(num1, num2, num3);

            Console.WriteLine("Maximum number is: " + maximum);
        }
    }
}
