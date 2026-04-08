using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class MostAppearingLetter
    {
        static void Main(string[] args)
        {
            //  input the string
            string s = Console.ReadLine();
            char m = ' ';
            int mc = 0;

            // checkingthe letter which appere most in a string
            for (int i = 0; i < s.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        c++;
                    }
                }
                // update the max count and the letter
                if (c > mc)
                {
                    mc = c;
                    m = s[i];
                }
            }
            Console.WriteLine(m);
        }
    }
}
