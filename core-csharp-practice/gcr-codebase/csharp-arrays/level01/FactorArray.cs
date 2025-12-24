using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FactorArray
    {
        static void Main()
        {
            //Take input from user
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;

            Loop to find factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Resize array if full

                    if (index == maxFactor)
                        {
                            maxFactor *= 2;
                            int[] temp = new int[maxFactor];

                            for (int j = 0; j < factors.Length; j++)
                            {
                                temp[j] = factors[j];
                            }
                            factors = temp;
                        }
                    factors[index++] = i;
                }

            }

            //Display factors 
            Console.WriteLine("\nFactors of " + number + ":");
            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }
        }
    }
}
