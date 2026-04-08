using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class TableInRange
    {
        static void Main()
        {
            //Take input number from user
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            //Array to stote results(for 6 to 9)
            int[] multiplicationResult = new int[4];

            int idx = 0;

            //loop from 6->9
            for (int i = 6; i <= 9; i++)
            {

                multiplicationResult[idx] = number * i;
                idx++;
            }

            //Display the table


            idx = 0;
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationResult[idx]);
                idx++;
            }
        }
    }
}
