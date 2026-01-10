using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class CountingSort
    {
        public static void Sort(int[] ages, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1;

            // Step 1: Create count array
            int[] count = new int[range];

            // Step 2: Store frequency of each age
            for (int i = 0; i < ages.Length; i++)
            {
                count[ages[i] - minAge]++;
            }

            // Step 3: Compute cumulative count
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 4: Create output array
            int[] output = new int[ages.Length];

            // Step 5: Place elements in correct position
            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int age = ages[i];
                int position = count[age - minAge] - 1;
                output[position] = age;
                count[age - minAge]--;
            }

            // Step 6: Copy output to original array
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = output[i];
            }
        }

        static void Main()
        {
            // Student ages (10 to 18)
            int[] studentAges = { 12, 15, 10, 18, 14, 12, 16 };

            // Apply Counting Sort
            Sort(studentAges, 10, 18);

            // Display sorted ages
            Console.WriteLine("Sorted Student Ages:");
            Console.WriteLine(string.Join(", ", studentAges));
        }

    }
}

   