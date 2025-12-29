using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class LongestWordInString
    {
        static void Main(string[] args)
        {
            // input the string
            string s = Console.ReadLine();
            string w = "";
            string lw = "";

            // traverse through the string to find the longest word
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    // end of a word
                    if (w.Length > lw.Length)
                    {
                        lw = w;
                    }
                    w = "";
                }
                else w += s[i];
            }
            // check for the last word
            if (w.Length > lw.Length) lw = w;
            Console.WriteLine(lw);
        }
    }
}
