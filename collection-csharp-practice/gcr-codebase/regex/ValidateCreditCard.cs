using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateCreditCard
    {
        static void Main()
        {
            string visaPattern = @"^4\d{15}$";
            string masterPattern = @"^5\d{15}$";

            string cardNumber = Console.ReadLine();

            if (Regex.IsMatch(cardNumber, visaPattern))
            {
                Console.WriteLine("Valid Visa Card");
            }
            else if (Regex.IsMatch(cardNumber, masterPattern))
            {
                Console.WriteLine("Valid MasterCard");
            }
            else
            {
                Console.WriteLine("Invalid Card Number");
            }
        }
    }
}
