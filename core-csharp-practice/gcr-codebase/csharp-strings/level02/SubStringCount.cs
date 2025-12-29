using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class SubStringCount
    {
        static void Main(string[] args)
        {
            // input the string and the substring
            string s = Console.ReadLine();
            string sub = Console.ReadLine();
            int c = 0;

            // traverse through the string to find the substring
            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                // check for the substring
                int j = 0;
                while (j < sub.Length && s[i + j] == sub[j])
                {
                    j++;
                }
                // if found increase the count
                if (j == sub.Length)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
