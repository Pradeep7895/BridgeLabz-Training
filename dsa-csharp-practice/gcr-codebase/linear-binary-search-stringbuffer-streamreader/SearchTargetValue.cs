using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class SearchTargetValue
    {
        static void Main()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            // Take matrix input
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());

            SearchMatrix(matrix, target);
        }

        static void SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int low = 0, high = rows * cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int value = matrix[mid / cols, mid % cols];

                if (value == target)
                {
                    Console.WriteLine("Target found");
                    return;
                }
                else if (value < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            Console.WriteLine("Target not found");
        }

    }
}

    