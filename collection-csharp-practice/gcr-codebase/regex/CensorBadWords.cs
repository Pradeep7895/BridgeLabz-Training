using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class CensorBadWords
    {
        static void Main()
        {
            string input = "This is a damn stupid and ugly example with nonsense words.";

            string[] badWords = { "damn", "stupid", "idiot", "ugly", "nonsense" };

            string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

            string result = Regex.Replace(
                input,
                pattern,
                "****",
                RegexOptions.IgnoreCase
            );

            Console.WriteLine(result);
        }
    }
}
