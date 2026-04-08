using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateSecurityNumber
    {
        static void Main()
        {
            Console.Write("Enter SSN: ");
            string ssn = Console.ReadLine();

            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            if (Regex.IsMatch(ssn, pattern))
            {
                Console.WriteLine(" SSN is valid");
            }
            else
            {
                Console.WriteLine(" SSN is invalid");
            }
        }
    }
}
