using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class HeapSort
    {
        // Main Heap Sort method
        public static void Sort(int[] salaries)
        {
            int n = salaries.Length;

            // Step 1: Build Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salaries, n, i);
            }

            // Step 2: Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                (salaries[0], salaries[i]) = (salaries[i], salaries[0]);

                // Call heapify on reduced heap
                Heapify(salaries, i, 0);
            }
        }

        // Heapify method to maintain max heap property
        private static void Heapify(int[] salaries, int heapSize, int rootIndex)
        {
            int largest = rootIndex;
            int left = 2 * rootIndex + 1;
            int right = 2 * rootIndex + 2;

            // Check left child
            if (left < heapSize && salaries[left] > salaries[largest])
                largest = left;

            // Check right child
            if (right < heapSize && salaries[right] > salaries[largest])
                largest = right;

            // If root is not largest, swap and continue heapifying
            if (largest != rootIndex)
            {
                (salaries[rootIndex], salaries[largest]) = (salaries[largest], salaries[rootIndex]);
                Heapify(salaries, heapSize, largest);
            }
        }

        static void Main()
        {
            // Salary demands of job applicants
            int[] salaryDemands = { 45000, 60000, 35000, 80000, 50000 };

            // Apply Heap Sort
            Sort(salaryDemands);

            // Display sorted salaries
            Console.WriteLine("Sorted Salary Demands in Ascending Order:");
            Console.WriteLine(string.Join(", ", salaryDemands));
        }

    }
}

