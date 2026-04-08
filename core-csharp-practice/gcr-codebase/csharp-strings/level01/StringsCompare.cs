using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class StringsCompare
    {
        static bool Compare(string str1, string str2)
        {
            //if length are not equal
            if(str1.Length != str2.Length)
                return false;

            //compare each character
            for (int i=0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    return false;
            
            }
            return true;
        }
        static void Main()
        {
            // Input two strings
            Console.WriteLine("Enter first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string str2 = Console.ReadLine();

            //compare using custom method
            bool isEqual = Compare(str1, str2);

            //compare using .equals method
            bool result = string.Equals(str1, str2);

            //display result
            Console.WriteLine("Using custom Compare method: " + isEqual);
            Console.WriteLine("Using string.Equals(): "+ result);
        }
    }
}
