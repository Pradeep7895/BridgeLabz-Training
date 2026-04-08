using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class LargestAndSecondLargestTwo
    {
        static void Main()
        {
            //taking inputs for array ,maxDigit abd index from user
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int maxDigit = 10;
            int[] arr = new int[maxDigit];
            int index = 0;

            while(number != 0)
            {
                //increase array size if needed
                if(index == maxDigit)
                {
                    maxDigit += 10;
                    int[] temp = new int[maxDigit];

                    for(int i=0;i<arr.Length;i++)
                        temp[i] = arr[i];
                    arr = temp;
                }
                arr[index++] = number % 10;
                number /= 10;
            }
            int largest = 0;
            int secondLargest = 0;

            //Find largest and second largest
            for (int i = 0; i < index; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
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
