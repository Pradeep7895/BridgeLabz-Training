using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class StoreAndSumUntilPressZero
    {
        static void Main()
        {

            //Declare array of size 10
            double[] numbers = new double[10];

            //To store total sum
            double total = 0.0;

            //index for array
            int idx = 0;

            Console.WriteLine("Enter numbers (0 or negative number to stop):");

            //Infinite loop to take user input
            while (true)
            {
                double input = Convert.ToDouble(Console.ReadLine());

                //stop if input is 0 or negative
                if (input <= 0)
                    break;

                //stop if array reaches 10
                if (input == 10)
                    break;

                //to store input arry
                numbers[idx] = input;
                idx++;
            }

            Console.WriteLine("Numbers entered:");

            //loop to display numbers and calculate sum
            for (int i = 0; i < idx; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }

            //display sum
            Console.WriteLine("Total sum= " + total);
        }
    }
}
