using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class PalindromeString
    {
        // inpu the string 
        static void Main(string[] args)
        {
            //  input the string
            string s = Console.ReadLine();
            int i = 0;


            // check for palindrome
            int j = s.Length - 1;
            bool f = true;
            while (i < j)
            {
                // compare the ith and jth character
                if (s[i] != s[j])
                {
                    f = false;
                    break;
                }
                i++;
                j--;
            }
            Console.WriteLine(f);
        }
    }
}
