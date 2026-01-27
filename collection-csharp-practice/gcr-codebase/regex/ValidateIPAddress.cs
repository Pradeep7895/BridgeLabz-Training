using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateIPAddress
    {
        static void Main()
        {
            string pattern = @"^((25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.){3}" +
                             @"(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)$";

            string ip = Console.ReadLine();

            Console.WriteLine(
                Regex.IsMatch(ip, pattern) ? "Valid IP Address" : "Invalid IP Address"
            );
        }
    }
}
