using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultiplicationTable
    {
        static void Main()
        {
            //Declare an aaray to store table
            int[] table = new int[10];

            //take user input
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());


            //Store table results from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }

            Console.WriteLine("Table: ");

            //Display Table
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + table[i - 1]);
            }
        }
    }
}
