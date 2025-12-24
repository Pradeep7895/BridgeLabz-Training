using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class TwoDimeToOneDime
    {
        static void Main()
        {
            //Take rows and columns
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            //Create 2D array
            int[,] matrix = new int[rows, columns];

            Console.WriteLine("Enter matrix elements: ");

            //Input for 2D matrix from user
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Create 1D array
            int[] arr = new int[rows * columns];
            int index = 0;

            //copy 2D array tp 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[index++] = matrix[i, j];
                }
            }

            //Display 1D array
            Console.WriteLine("\n1D array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
