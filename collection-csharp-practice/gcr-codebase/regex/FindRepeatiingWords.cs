using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class FindRepeatiingWords
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(\w+)\s+\1\b";

            MatchCollection matches = Regex.Matches(
                input,
                pattern,
                RegexOptions.IgnoreCase
            );

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
        }
    }
}
