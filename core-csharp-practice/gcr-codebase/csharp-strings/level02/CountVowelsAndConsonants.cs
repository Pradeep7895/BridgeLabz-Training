using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level02
{
    internal class CountVowelsAndConsonants
    {
        // method to count vowels and consonants
        static void CountVC(string input, out int vowels, out int consonents)
        {
            vowels = 0;
            consonents = 0;

            //convert string to lower case
            input = input.ToLower();

            for(int i = 0; i < input.Length; i++)
            {
                // check if character is a letter
                char ch = input[i];

                if(ch >='a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonents++;
                }
            }
        }
        static void Main()
        {
            //input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            //method call
            CountVC(input, out int vowels, out int consonents);

            Console.WriteLine($"Number of Vowels: {vowels}");
            Console.WriteLine($"Number of Consonants: {consonents}");
        }
    }
}
