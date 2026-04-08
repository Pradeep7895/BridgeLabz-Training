using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateHexColor
    {
        static void Main()
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";

            Console.Write("Enter hex color code: ");
            string color = Console.ReadLine();

            if (Regex.IsMatch(color, pattern))
            {
                Console.WriteLine("Valid Hex Color Code");
            }
            else
            {
                Console.WriteLine("Invalid Hex Color Code");
            }
        }
    }
}
