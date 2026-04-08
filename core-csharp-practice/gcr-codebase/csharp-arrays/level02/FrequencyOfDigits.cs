using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class FrequencyOfDigits
    {
        static void Main()
        {
            //Take input number
            Console.Write("Enter a number :");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int count = 0;

            // Find the number of digits

            while(temp != 0)
            {
                count++;
                temp /= 10;

            }
            //To store digits
            int[] digits = new int[count];

            for(int i = 0; i < count; i++)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            // Calculate frequency of each digit
            int[] frequency = new int[10];

            for(int i = 0; i < count; i++)
            {
                frequency[digits[i]]++;

            }
            //dispaly frequency
            Console.WriteLine("\nDigit Frequency:");
            for(int i=0; i < 10; i++)
            {
                if(frequency[i] > 0)
                {
                    Console.WriteLine("Digit " + i + " occurs " + frequency[i] + "times");
                }
            }
        }
    }
}
