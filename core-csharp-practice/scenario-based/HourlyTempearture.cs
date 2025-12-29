using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Scenario: 
// You're analyzing a week’s worth of hourly temperature data stored in a 2D array (float[7][24]). 
// Problem: Write a method to:
// ● Find the hottest and coldest day, 
// ● Return average temperature per day.

namespace BridgeLabzTraining.scenario_based
{
    internal class HourlyTemperature
    {
        // Method to calculate average temperature for each day
        static float[] DailyAverages(float[,] temps)
        {
            // Array to hold average temperatures for each day
            float[] averages = new float[7];

            for (int day = 0; day < 7; day++)
            {
                float sum = 0;

                for (int hour = 0; hour < 24; hour++)
                {
                    // Accumulate temperature for the day
                    sum += temps[day, hour];
                }
                // Calculate average for the day
                averages[day] = sum / 24;
            }

            return averages;
        }

        // Method to find hottest and coldest day
        static void HottestAndColdestDay(float[] averages)
        {
            int hottestDay = 0;
            int coldestDay = 0;

            for (int i = 1; i < averages.Length; i++)
            {
                // Compare to find hottest day
                if (averages[i] > averages[hottestDay])
                    hottestDay = i;
                // Compare to find coldest day
                if (averages[i] < averages[coldestDay])
                    coldestDay = i;
            }
            // Output results
            Console.WriteLine("Hottest Day  : Day " + (hottestDay + 1));
            Console.WriteLine("Coldest Day : Day " + (coldestDay + 1));
        }

        static void Main()
        {
            // 2D array to hold temperatures for 7 days and 24 hours
            float[,] temperatures = new float[7, 24];

            Random random = new Random();

            // Fill array with random temperatures (
            for (int day = 0; day < 7; day++)
            {
                for (int hour = 0; hour < 24; hour++)
                {
                    temperatures[day, hour] = random.Next(15, 40); 
                }
            }
            // Calculate daily averages
            float[] dailyAverages = DailyAverages(temperatures);

            // Print daily averages
            Console.WriteLine("Average Temperature Per Day:");
            for (int i = 0; i < dailyAverages.Length; i++)
            {
                Console.WriteLine("Day " + (i + 1) + ": " + dailyAverages[i]);
            }

            // Find and print hottest and coldest day
            Console.WriteLine();
            HottestAndColdestDay(dailyAverages);
        }
    }
}

        
