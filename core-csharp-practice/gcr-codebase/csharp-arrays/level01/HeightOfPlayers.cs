using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class HeightOfPlayers
    {
        static void Main()
        {
            //Declare array to store heights
            double[] heights = new double[11];
            double sum = 0.0;

            Console.WriteLine("Enter heights of 11 players:");

            //Take input from user
            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write("Player " + (i + 1) + " height: ");
                heights[i] = double.Parse(Console.ReadLine());
                sum += heights[i];
            }

            //calculate mean
            double mean = sum / heights.Length;

            //Display mean height
            Console.WriteLine("Mean height of football team = " + mean);
        }
    }
}
