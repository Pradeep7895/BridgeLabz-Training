using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class LargestAndSecondLargest
    {
        static void Main()
        {
            //Input number from user
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            //declare an array
            int maxDigit = 10;
            int[] arr = new int[maxDigit];
            int index = 0;

            //Extract digits of number
            while(number !=0 && index < maxDigit)
            {
                arr[index++]= number % 10;
                number /= 10;
            }

            int largest = 0;
            int secondLargest = 0;

            //Find largest and second largest
            for(int i = 0; i < index; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if(arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }
            //Display result
            Console.WriteLine("Largest Digit = " + largest);
            Console.WriteLine("Second Largest digit = " + secondLargest);
        }
    }
}
