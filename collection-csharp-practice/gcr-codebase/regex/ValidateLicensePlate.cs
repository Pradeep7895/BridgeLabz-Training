using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateLicensePlate
    {
        static void Main()
        {
            string pattern = @"^[A-Z]{2}\d{4}$";

            Console.Write("Enter license plate number: ");
            string plate = Console.ReadLine();

            if (Regex.IsMatch(plate, pattern))
            {
                Console.WriteLine("Valid License Plate");
            }
            else
            {
                Console.WriteLine("Invalid License Plate");
            }
        }
    }
}
