using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class MergeSort
    {
        // Method to perform Merge Sort
        public static void Sort(int[] prices, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Sort left half
                Sort(prices, left, mid);

                // Sort right half
                Sort(prices, mid + 1, right);

                // Merge both halves
                Merge(prices, left, mid, right);
            }
        }

        // Method to merge two sorted halves
        private static void Merge(int[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data into temporary arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = prices[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = prices[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            // Merge the arrays by comparison
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    prices[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    prices[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            // Copy remaining elements (if any)
            while (iIndex < n1)
            {
                prices[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                prices[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }

        static void Main()
        {
            // Array of book prices
            int[] bookPrices = { 450, 299, 799, 199, 599 };

            // Perform Merge Sort
            Sort(bookPrices, 0, bookPrices.Length - 1);

            // Display sorted prices
            Console.WriteLine("Sorted Book Prices in Ascending Order:");
            Console.WriteLine(string.Join(", ", bookPrices));
        }

    }
}

    