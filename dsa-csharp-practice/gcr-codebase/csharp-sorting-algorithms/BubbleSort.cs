using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class BubbleSort
    {
        // Bubble Sort method
        public static void Sort(int[] marks)
        {
            int n = marks.Length;
            bool swapped;

            // Outer loop for passes
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                // Inner loop for comparisons
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if elements are in wrong order
                    if (marks[j] > marks[j + 1])
                    {
                        (marks[j], marks[j + 1]) = (marks[j + 1], marks[j]);
                        swapped = true;
                    }
                }

                // If no swap happened, array is already sorted
                if (!swapped)
                    break;
            }
        }

        static void Main()
        {
            // Student marks array
            int[] marks = { 78, 45, 90, 62, 88, 50 };

            // Sort the marks
            Sort(marks);

            // Display sorted marks
            Console.WriteLine("Sorted Student Marks (Ascending Order):");
            Console.WriteLine(string.Join(", ", marks));
        }

    }
}

    