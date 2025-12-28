using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level02
{
    internal class StringReverse
    {
        //method to reverse a string
        static string Reverse(string input)
        {
            string reversed = "";

            for(int i = input.Length -1;i >= 0 ; i--)
            {
                reversed += input[i];
            }
            return reversed;
        }
        static void Main()
        {
            //input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            //method call
            string reversedString = Reverse(input);

            Console.WriteLine("Reversed string: " + reversedString);
        }
    }
}
