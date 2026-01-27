using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateUsername
    {
        static void Main()
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (Regex.IsMatch(username, pattern))
            {
                Console.WriteLine("Valid Username");
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }

    }
}

  
