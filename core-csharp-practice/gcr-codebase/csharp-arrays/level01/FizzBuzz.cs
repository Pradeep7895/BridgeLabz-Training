using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FizzBuzz
    {
        static void Main()
        {
            //input number
            Console.WriteLine("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());

            //validate the number
            if(number <=0 )
            {
                Console.WriteLine("Invalid number");
                return;
            }
            //String array
            string[] array = new string[number+1];

            //store results
            for(int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i != 0)
                    array[i] = "FizzBuzz";
                else if (i % 3 == 0 && i != 0)
                    array[i] = "Fizz";
                else if (i % 5 == 0 && i != 0)
                    array[i] = "Buzz";
                else
                    array[i] = i.ToString();
            }

            //Display result
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine("Position " + i + " = " + array[i]);
            }
        }
    }
}
