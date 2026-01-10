using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class SelectionSort
    {
        // Method to perform Selection Sort
        public static void Sort(int[] scores)
        {
            int n = scores.Length;

            // Loop through each position in the array
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                // Find index of minimum element in unsorted part
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with first unsorted element
                if (minIndex != i)
                {
                    (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
                }
            }
        }

        static void Main()
        {
            // Array of exam scores
            int[] examScores = { 72, 88, 65, 90, 78 };

            // Sort the scores
            Sort(examScores);

            // Display sorted exam scores
            Console.WriteLine("Sorted Exam Scores in Ascending Order:");
            Console.WriteLine(string.Join(", ", examScores));
        }

    }
}

    