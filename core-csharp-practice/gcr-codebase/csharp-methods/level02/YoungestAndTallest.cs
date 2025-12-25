using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class YoungestAndTallest
    {

        // Method to find youngest age
        static int Youngest(int[] ages)
        {
            int min = ages[0];

            for (int i = 1; i < ages.Length; i++)
                if (ages[i] < min)
                    min = ages[i];

            return min;
        }

        // Method to find tallest height
        static int Tallest(int[] heights)
        {
            int max = heights[0];

            for (int i = 1; i < heights.Length; i++)
                if (heights[i] > max)
                    max = heights[i];

            return max;
        }
        static void Main()
        {
            int[] ages = new int[3];
            int[] heights = new int[3];

            // Take input for 3 friends
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of friend {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.Write($"Enter height of friend {i + 1}: ");
                heights[i] = int.Parse(Console.ReadLine());
            }

            // Display results
            Console.WriteLine("Youngest Age = " + Youngest(ages));
            Console.WriteLine("Tallest Height = " + Tallest(heights));
        }
    }
}
