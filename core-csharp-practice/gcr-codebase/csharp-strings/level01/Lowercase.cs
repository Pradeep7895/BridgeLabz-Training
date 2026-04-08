using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class Lowercase
    {
        //to lowercase using ASCII logic
        static string ToLowerASCII(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                    result += (char)(c + 32);
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

            Console.WriteLine("ASCII lowercase: " + ToLowerASCII(input));
            Console.WriteLine("Built-in lowercase: " + input.ToLower());
        }
    }
}
