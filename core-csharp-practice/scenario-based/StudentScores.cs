using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    internal class StudentScores
    {
        // Method to get number of students
        public int GetCount()
        {
            int count;

            Console.Write("Enter number of students: ");
            count = int.Parse(Console.ReadLine());

            // Keep asking until a positive number is entered
            while (count <= 0)
            {
                Console.Write("Invalid input. Enter a positive number: ");
                count = int.Parse(Console.ReadLine());
            }

            return count;
        }

        // Method to take student scores
        public int[] GetScores(int count)
        {
            // Array to hold scores
            int[] scores = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter score for student " + (i + 1) + ": ");
                scores[i] = int.Parse(Console.ReadLine());

                // Ensure score is non-negative
                while (scores[i] < 0)
                {
                    Console.Write("Invalid score. Enter a non-negative number: ");
                    scores[i] = int.Parse(Console.ReadLine());
                }
            }

            return scores;
        }

        // Method to calculate average score
        public double Average(int[] scores)
        {
            int sum = 0;
            // Calculate sum of scores
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            // Calculate and return average
            return (double)sum / scores.Length;
        }

        // Method to find highest score
        public int Highest(int[] scores)
        {
            int highest = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                // Check for highest score
                if (scores[i] > highest)
                {
                    highest = scores[i];
                }
            }

            return highest;
        }

        // Method to find lowest score
        public int Lowest(int[] scores)
        {
            int lowest = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                // Check for lowest score
                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                }
            }

            return lowest;
        }

        // Method to display scores above average
        public void AboveAverage(int[] scores, double average)
        {
            Console.WriteLine("\nScores above average:");
            // Flag to check if any score is above average
            bool found = false;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > average)
                {
                    Console.WriteLine(scores[i]);
                    // Set flag to true
                    found = true;
                }
            }
            // If no scores above average
            if (!found)
            {
                Console.WriteLine("No scores above average.");
            }
        }

        static void Main()
        {
            StudentScores manager = new StudentScores();

            // Get number of students
            int count = manager.GetCount();

            // Get scores
            int[] scores = manager.GetScores(count);

            // Calculate results
            double avg = manager.Average(scores);
            int high = manager.Highest(scores);
            int low = manager.Lowest(scores);

            // Display results
            Console.WriteLine("\nAverage Score: " + avg);
            Console.WriteLine("Highest Score: " + high);
            Console.WriteLine("Lowest Score : " + low);

            manager.AboveAverage(scores, avg);
        }
    }
}
