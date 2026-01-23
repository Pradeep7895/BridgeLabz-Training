using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.exceptions
{
    internal class NestedTryCatchBlocks
    {
        static void Main()
        {
            int[] arr = { 10, 20, 30, 40 };

            try   // Outer try
            {
                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());

                try   // Inner try
                {
                    Console.Write("Enter divisor: ");
                    int divisor = int.Parse(Console.ReadLine());

                    int result = arr[index] / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers");
            }
        }

    }
}

    