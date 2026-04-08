using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class ReturnAllCharacters
    {
        //method to return all characters
        static char[] GetCharacters(string input)
        {
            char[] chars = new char[input.Length];
            for(int i=0;i<input.Length; i++)
            {
                chars[i] = input[i];
            }
            return chars;
        }
        static void Main()
        {
            //input string 
            Console.WriteLine("Enter a string: ");
            string input  = Console.ReadLine();

            char[] character = GetCharacters(input);
            char[] buildIn = input.ToCharArray();

            //display result
            Console.WriteLine("Using CharAt method: " + string.Join(", ", character));
            Console.WriteLine("Using built-in method: " + string.Join(", ", buildIn));

        }
    }
}
