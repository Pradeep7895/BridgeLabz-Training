using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class CheckNumber
    {
        static int Check(int number)
        {

            // If number is positive
            if (number > 0)
                return 1;

            // If number is negative
            if (number < 0)
                return -1;

            // If number is zero
            return 0;

        }
        static void Main()
        {

            // Take input
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Call method
            int result = Check(number);


            // Print result
            Console.WriteLine("Result = " + result);

        }
    }
}
