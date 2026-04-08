using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class WordSplit
    {
        // Method to calculate length without using Length
        static int GetLength(string word)
        {
            int count = 0;
            foreach (char c in word)
                count++;
            return count;
        }

        // Method to split words and return 2D array
        static string[,] SplitWordsAndLengths(string text)
        {
            //temporarily store words
            string[] words = new string[100];
            int wordCount = 0;
            string currentWord = "";

            foreach (char c in text + " ")
            {
                // If space is found, word is completed
                if (c == ' ')
                {
                    if (currentWord != "")
                    {
                        words[wordCount++] = currentWord;
                        currentWord = "";
                    }
                }
                else
                {
                    // Add character to current word
                    currentWord += c;
                }
            }

            //create 2D array to hold words and lengths
            string[,] result = new string[wordCount, 2];

            for (int i = 0; i < wordCount; i++)
            {
                result[i, 0] = words[i];
                result[i, 1] = GetLength(words[i]).ToString();
            }

            return result;
        }

        static void Main()
        {
            //input string
            string text = "Welcome to CSharp";

            string[,] data = SplitWordsAndLengths(text);

            //display the result
            Console.WriteLine("Word - Length");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine(data[i, 0] + " - " + data[i, 1]);
            }
        }
    }
}

        
