using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.regex
{
    internal class ReplaceModifyStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\s+";

            string result = Regex.Replace(input, pattern, " ");

            Console.WriteLine(result);
        }
    }
}
