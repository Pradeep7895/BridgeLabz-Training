using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class FormatExceptionDemo
    {
        // Method to generate FormatException
        static void Generate()
        {
            string value = "ABC";

            // This will throw FormatException
            int number = int.Parse(value);
            Console.WriteLine(number);
        }

        // Method to handle FormatException
        static void Handle()
        {
            string value = "ABC";

            try
            {
                int number = int.Parse(value);
                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException caught");
                Console.WriteLine("Error Message: " + ex.Message);

                // Safe recovery
                int defaultValue = 0;
                Console.WriteLine("Handling by assigning default value: " + defaultValue);
            }
        }

        static void Main()
        {
            // Uncomment to see exception 
             //Generate();

            // Handle the exception
            Handle();
        }
    }
}
