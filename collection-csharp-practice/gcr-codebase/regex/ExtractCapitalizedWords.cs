using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractCapitalizedWords
    {
        static void Main()
        {
            Console.WriteLine("Enter Sentence : ");
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]*\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
