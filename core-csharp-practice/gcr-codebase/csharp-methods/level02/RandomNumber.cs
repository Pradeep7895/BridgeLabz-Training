using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class RandomNumber
    {

        //generate array of 4-digit random numbers
        public static int[] GenerateRandomArray(int size)
        {
            int[] numbers = new int[size];
            Random random = new Random();

            // random numbers between 1000 and 9999
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1000, 10000);
            }

            return numbers;
        }

        public static double[] AverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            //calculate sum, min and max
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);
            }

            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }

        static void Main()
        {
            // Generate array 
            int[] numbers = GenerateRandomArray(5);

            // Display numbers
            Console.WriteLine("Generated 4-digit random numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Find average, min, and max
            double[] result = AverageMinMax(numbers);

            // Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Average = " + result[0]);
            Console.WriteLine("Minimum = " + result[1]);
            Console.WriteLine("Maximum = " + result[2]);
        }
    }
}
