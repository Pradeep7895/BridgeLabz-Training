using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractCurrencyValues
    {
        static void Main()
        {
            string input = "The price is $45.99, and the discount is $ 10.50.";
            string pattern = @"\$\s?\d+(\.\d{2})?";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
