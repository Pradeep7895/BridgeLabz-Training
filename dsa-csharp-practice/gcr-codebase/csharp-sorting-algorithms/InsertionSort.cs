using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class InsertionSort
    {
        // Method to perform Insertion Sort
        public static void Sort(int[] empIds)
        {
            int n = empIds.Length;

            // Start from the second element
            for (int i = 1; i < n; i++)
            {
                // Element to be inserted
                int key = empIds[i];   
                int j = i - 1;

                // Shift elements greater than key to the right
                while (j >= 0 && empIds[j] > key)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }

                // Insert key at the correct position
                empIds[j + 1] = key;
            }
        }

        static void Main()
        {
            
            int[] employeeIds = { 105, 102, 110, 101, 108 };

            // Sort the IDs
            Sort(employeeIds);

            // Display sorted employee IDs
            Console.WriteLine("Sorted Employee IDs in Ascending Order:");
            Console.WriteLine(string.Join(", ", employeeIds));
        }

    }
}

    