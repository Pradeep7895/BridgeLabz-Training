using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level2
{
    internal class YoungestAndTallest
    {
        static void Main()
        {
            //Declare arrays
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] height = new double[3];

            //Take input 
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter age of " + names[i] + ":");
                ages[i] = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter height of " + names[i] + ": ");
                height[i] = int.Parse(Console.ReadLine()!);
            }

            int indexYoung = 0;
            int indexTall = 0;

            //Find youngest and tallest among three
            for(int i = 1; i < 3; i++)
            {
                if (ages[i] < ages[i - 1])
                    indexYoung = i;
                if (height[i] > height[i - 1])
                    indexTall = i;
            }

            //display result
            Console.WriteLine("\nYoungest Friend: " + names[indexYoung]);
            Console.WriteLine("Tallest Friend: " + names[indexTall]);

        }
    }
}
