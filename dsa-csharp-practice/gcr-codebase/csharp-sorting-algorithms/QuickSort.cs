using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class QuickSort
    {
        // Quick Sort method
        public static void Sort(int[] prices, int low, int high)
        {
            if (low < high)
            {
                // Find pivot position
                int pivotIndex = Partition(prices, low, high);

                // Sort elements before and after pivot
                Sort(prices, low, pivotIndex - 1);
                Sort(prices, pivotIndex + 1, high);
            }
        }

        // Partition method
        private static int Partition(int[] prices, int low, int high)
        {
            int pivot = prices[high]; // pivot element (last element)
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // Move smaller elements to the left of pivot
                if (prices[j] < pivot)
                {
                    i++;
                    (prices[i], prices[j]) = (prices[j], prices[i]);
                }
            }

            // Place pivot in correct position
            (prices[i + 1], prices[high]) = (prices[high], prices[i + 1]);

            return i + 1;
        }

        static void Main()
        {
            // Array of product prices
            int[] productPrices = { 1200, 450, 999, 299, 799 };

            // Apply Quick Sort
            Sort(productPrices, 0, productPrices.Length - 1);

            // Display sorted prices
            Console.WriteLine("Sorted Product Prices (Ascending Order):");
            Console.WriteLine(string.Join(", ", productPrices));
        }

    }
}

    