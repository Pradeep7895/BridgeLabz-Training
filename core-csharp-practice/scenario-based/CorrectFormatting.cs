using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem:
//Write a method that takes a paragraph as input and returns a corrected version with:
//● One space after punctuation,
//● Capital letter after period/question/exclamation marks,
//● Trimmed extra spaces.

namespace BridgeLabzTraining.scenario_based
{

    internal class CorrectFormatting
    {
        static string RemoveExtraSpaces(string input)
        {
            string result = "";
            int i = 0;

            // Skip leading spaces
            while (i < input.Length && input[i] == ' ')
                i++;

            //false → a space is allowed
            //true → a space was already added
            bool spaceAllowed = false;

            for (; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    //only one space is added
                    if (!spaceAllowed)
                    {
                        result += ' ';
                        spaceAllowed = true;
                    }
                }
                else
                {
                    result += input[i];
                    spaceAllowed = false;
                }
            }

            // Remove trailing space if exists
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }

        static string CapitalLetter(string input)
        {
            string result = "";

            //true → next char should be capital
            //false → next char should be normal
            bool nextCharValue = true;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (nextCharValue && ch >= 'a' && ch <= 'z')
                {
                    //using ASCII value
                    result += (char)(ch - 32);
                    nextCharValue = false;
                }
                else
                {
                    result += ch;
                }
                if (ch == '.' || ch == '?' || ch == '!' || ch == ',')
                {
                    //set flag to true
                    nextCharValue = true;
                }
            }
            return result;
        }
        static string AddSpace(String input)
        {
            string result = " ";
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
                if (input[i] == '.' || input[i] == '?' || input[i] == '!' || input[i] == ',' || input[i] == ';' || input[i] == ':' || input[i] == '(' || input[i] == ')')
                {
                    if (i + 1 < input.Length && input[i + 1] != ' ')
                    {
                        result += ' ';
                    }
                }
            }
            return result;
        }
        static void Main()
        {
            // Input paragraph
            Console.WriteLine("Enter a paragraph:");
            string input = Console.ReadLine();

            input = RemoveExtraSpaces(input);
            input = AddSpace(input);
            input = CapitalLetter(input);


            Console.WriteLine("\nCorrected Paragraph:");
            Console.WriteLine(input);
        }
    }
}

