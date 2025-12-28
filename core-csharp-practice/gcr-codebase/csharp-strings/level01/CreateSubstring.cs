using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class CreateSubstring
    {
        //method to create substring
        static string SubstringUsingCharAt(string input, int start, int end)
        {
            string result = "";
            for(int i = start; i <= end; i++)
            {
                result += input[i];
            }
            return result; 
        }
        static void Main()
        {
            //input string
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            //Start index
            Console.WriteLine("Enter start index: ");
            int start = int.Parse(Console.ReadLine());

            //End index
            Console.WriteLine("Enter end index: ");
            int end = int.Parse(Console.ReadLine());

            //charAt method
            string substring = SubstringUsingCharAt(input, start, end);

            //bild in method
            string buildInSubstring = input.Substring(start, end - start + 1);
            
            //display result
            Console.WriteLine("Substring using charAt method: " + substring);
            Console.WriteLine("Substring using built-in method: " + buildInSubstring);

            //compare result 
            Console.WriteLine("Are both substrings equal? " + string.Equals(substring, buildInSubstring) );
        }
    }
}
