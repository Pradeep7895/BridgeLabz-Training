using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class UpperCase
    {
        // uppercase using ASCII logic
        static string ToUpperASCII(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                    result += (char)(c - 32);
                else
                    result += c;
            }
            return result;
        }

        static void Main()
        {
            //input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Console.WriteLine("ASCII Uppercase: " + ToUpperASCII(input));
            Console.WriteLine("Built-in Uppercase: " + input.ToUpper());
        }
    }
}
