using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractProgrammingLanguage
    {
        static void Main()
        {
            string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

            string[] languages = { "Java", "Python", "JavaScript", "Go" };

            string pattern = @"\b(" + string.Join("|", languages) + @")\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
