using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class ToggleCaseString
    {
        static void Main(string[] args)
        {
            // input the string
            string s = Console.ReadLine();
            string t = "";

            // if the char is lower case the change it to upper case and vise versa
            for (int i = 0; i < s.Length; i++)
            {
                // get the char at the index
                char c = s[i];
                if (c >= 'a' && c <= 'z')
                {
                    // change to upper case
                    c = (char)(c - 32);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    // change to lower case
                    c = (char)(c + 32);
                }
                t += c;
            }
            // print the result string
            Console.WriteLine(t);
        }
    }
}
