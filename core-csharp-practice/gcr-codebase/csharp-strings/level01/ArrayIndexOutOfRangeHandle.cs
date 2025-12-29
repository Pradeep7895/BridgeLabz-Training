using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class ArrayIndexOutOfRangeHandle
    {
        // Method to generate IndexOutOfRangeException
        static void Generate()
        {
            int[] arr = { 10, 20, 30 };

            //throw IndexOutOfRangeException
            Console.WriteLine(arr[5]);
        }

        // to handle IndexOutOfRangeException
        static void Handle()
        {
            int[] arr = { 10, 20, 30 };

            try
            {
                // Invalid index access
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught");
                Console.WriteLine("Error Message: " + ex.Message);

                // Safe recovery
                Console.WriteLine("Handling exception by displaying valid elements:");
                foreach (int num in arr)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Main()
        {
            // Uncomment to see exception generation
            //Generate();

            // Handle the exception
            Handle();
        }
    }
}
