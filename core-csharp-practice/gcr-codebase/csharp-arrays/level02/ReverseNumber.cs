using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class ReverseNumber
    {
        static void Main()
        {
            //take input from user
            Console.Write("Enter a number: ");
            int number =int.Parse(Console.ReadLine()!);

            int temp = number;
            int count = 0;

            //count the digits of number
            while(temp != 0)
            {
                count++;
                temp /= 10;
            }
            int[] digitsArr = new int[count];

            //store values in digits array
            for(int i = 0; i < count; i++)
            {
                digitsArr[i] = number % 10;
                number /= 10;

            }
           
            //reverse numbers
            Console.WriteLine("\nReversed Number: ");
            for(int i = 0; i < count; i++)
            {
                Console.Write(digitsArr[i]);
            }

        }
    }
}
