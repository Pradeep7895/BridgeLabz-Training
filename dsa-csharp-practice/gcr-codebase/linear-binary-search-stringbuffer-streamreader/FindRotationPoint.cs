using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class FindRotationPoint
    {
        static void Main()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int index = RotationPoint(arr);
            Console.WriteLine("Rotation index: " + index);
            Console.WriteLine("Smallest element: " + arr[index]);
        }

        static int RotationPoint(int[] arr)
        {
            int low = 0, high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] > arr[high])
                    low = mid + 1;
                else
                    high = mid;
            }
            return low;
        }

    }
}

    