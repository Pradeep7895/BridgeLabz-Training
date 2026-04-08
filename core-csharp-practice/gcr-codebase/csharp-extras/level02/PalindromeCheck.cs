using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02
{
    internal class PalindromeCheck
    {
        static void Main(string[] args)
        {
            // input the string
            string s = Console.ReadLine();
            Console.WriteLine(Check(s));
        }
        // checkinng if the number is a palindrome
        static bool Check(string s)
        {
            // two pointers
            int i = 0;
            int j = s.Length - 1;
            // traversing from both the ends
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
