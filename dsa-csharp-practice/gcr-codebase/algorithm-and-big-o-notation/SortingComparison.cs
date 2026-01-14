using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.algorithm_and_big_o_notation
{
    internal class SortingComparison
    {
        // Bubble Sort (O(N^2)) 
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort (O(N log N)) 
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
                arr[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];

            while (i < n1) arr[k++] = L[i++];
            while (j < n2) arr[k++] = R[j++];
        }

        // Quick Sort (O(N log N))
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;

            return i + 1;
        }

        
        static void Main()
        {
            int[] datasetSizes = { 1000, 10000 };

            foreach (int size in datasetSizes)
            {
                Console.WriteLine($"\nDataset Size: {size}");

                int[] original = GenerateArray(size);

                // Bubble Sort
                int[] bubbleArr = (int[])original.Clone();
                Stopwatch sw = Stopwatch.StartNew();
                BubbleSort(bubbleArr);
                sw.Stop();
                Console.WriteLine($"Bubble Sort Time: {sw.ElapsedMilliseconds} ms");

                // Merge Sort
                int[] mergeArr = (int[])original.Clone();
                sw.Restart();
                MergeSort(mergeArr, 0, mergeArr.Length - 1);
                sw.Stop();
                Console.WriteLine($"Merge Sort Time: {sw.ElapsedMilliseconds} ms");

                // Quick Sort
                int[] quickArr = (int[])original.Clone();
                sw.Restart();
                QuickSort(quickArr, 0, quickArr.Length - 1);
                sw.Stop();
                Console.WriteLine($"Quick Sort Time: {sw.ElapsedMilliseconds} ms");
            }

            Console.WriteLine("\nNote: Bubble Sort is not tested for 1,000,000 elements (impractical).");
        }

        static int[] GenerateArray(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = random.Next(1, size);
            return arr;
        }


    }
}

   