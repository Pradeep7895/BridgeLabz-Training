using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.Level02
{
    internal class RemoveDuplicateLetter
    {
        static void Main(string[] args)
        {
            // input the string
            string s = Console.ReadLine();
            string r = "";


            // removing the duplicate letter
            for (int i = 0; i < s.Length; i++)
            {
                // check if the letter is already in the result string
                bool f = false;
                for (int j = 0; j < r.Length; j++)
                {
                    // compare the letters
                    if (s[i] == r[j])
                    {
                        f = true;
                    }
                }
                // if not found add it to the result string
                if (!f)
                {
                    r += s[i];
                }
            }
            // print the result string
            Console.WriteLine(r);
        }
    }
}
