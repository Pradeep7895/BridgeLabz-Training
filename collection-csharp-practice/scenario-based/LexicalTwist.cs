using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Collections.collection_csharp_practice.senario_based
{
    internal class LexicalTwist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word");
            string first = Console.ReadLine()!;
            if (ManyWords(first))
            {
                Console.WriteLine("the string is invalid");
            }
            Console.WriteLine("Enter second word");
            string second = Console.ReadLine()!;
            if (ManyWords(second))
            {
                Console.WriteLine("the string is invalid");
            }
            if (IsReversed(first, second))
            {
                string result = Regex.Replace(second.ToLower(), @"[aeiou]", "@");
                Console.WriteLine("The Output is " + result);
            }
            else
            {
                IfNotReverse(first, second);
            }

        }

        private static bool IsReversed(String first, String second)
        {
            string temp = "";
            char[] secondarr = second.ToCharArray();
            for (int i = secondarr.Length - 1; i >= 0; i--)
            {
                temp += secondarr[i];
            }
            if (first.Equals(temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ManyWords(string s)
        {
            MatchCollection matches = Regex.Matches(s, @"\b\w+\b");
            return matches.Count > 1;
        }

        static void IfNotReverse(string first, string second)
        {
            string both = first + second;
            both = both.ToUpper();
            char[] botharr = both.ToCharArray();
            string vowels = "";
            string con = "";
            foreach (char i in botharr)
            {
                if ("AEIOU".Contains(i))
                {
                    vowels += i;
                }
                else
                {
                    con += i;
                }
            }
            if (vowels.Length > con.Length)
            {
                Console.WriteLine(vowels.Substring(0, 2));
            }
            else if (vowels.Length < con.Length)
            {
                Console.WriteLine(con.Substring(0, 2));
            }
            else
            {
                Console.WriteLine("Vowels and consonantsare equal");
            }
        }
    }
}