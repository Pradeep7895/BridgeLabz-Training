using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class TeamHeights
    {

        // Method to calculate sum of all heights
        public static int FindSum(int[] heights)
        {
            int sum = 0;

            // Loop through array to calculate sum
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }

            return sum;
        }

        // Method to calculate mean height
        public static double FindMean(int[] heights)
        {
            // Mean = sum of elements / number of elements
            return (double)FindSum(heights) / heights.Length;
        }

        // Method to find shortest height
        public static int FindShortest(int[] heights)
        {
            int min = heights[0];

            // Compare each height to find minimum
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < min)
                    min = heights[i];
            }

            return min;
        }

        // Method to find tallest height
        public static int FindTallest(int[] heights)
        {
            int max = heights[0];

            // Compare each height to find maximum
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > max)
                    max = heights[i];
            }

            return max;
        }

        static void Main()
        {
            // Create array to store heights of 11 players
            int[] heights = new int[11];

            // Random object to generate heights
            Random random = new Random();

            // Generate random heights between 150 and 250 cm
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 251);
            }

            // Display all player heights
            Console.WriteLine("Heights of Football Players (in cm):");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " : " + heights[i]);
            }

            // Call methods to calculate results
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);
            double mean = FindMean(heights);

            // Display final results
            Console.WriteLine("\n--- Results ---");
            Console.WriteLine("Shortest Height = " + shortest + " cm");
            Console.WriteLine("Tallest Height = " + tallest + " cm");
            Console.WriteLine("Mean Height = " + mean + " cm");
        }
    }
}
