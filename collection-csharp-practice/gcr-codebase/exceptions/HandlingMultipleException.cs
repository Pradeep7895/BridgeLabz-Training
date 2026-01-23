using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.exceptions
{
    internal class HandlingMultipleException
    {
        static void Main()
        {
            try
            {
                // You can change this to null to test NullReferenceException
                int[] arr = { 10, 20, 30, 40 };

                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine($"Value at index {index}: {arr[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

    }
}

  
