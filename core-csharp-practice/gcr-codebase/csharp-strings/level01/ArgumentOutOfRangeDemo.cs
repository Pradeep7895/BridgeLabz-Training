
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BridgeLabzTraining.strings.level01
{
    internal class ArgumentOutOfRangeDemo
    {
        // Method to generate exception
        static void Generate()
        {
            string text = "Hello";

            // This will throw ArgumentOutOfRangeException
            Console.WriteLine(text.Substring(5, 3));
        }

        // Method to handle exception
        static void Handle()
        {
            string text = "Hello"; 

            try
            {
                Console.WriteLine(text.Substring(3, 10));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ArgumentOutOfRangeException caught");
                Console.WriteLine("Error Message: " + ex.Message);

                // Safe recovery
                Console.WriteLine("Handling exception by using full string:");
                Console.WriteLine(text); 
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
