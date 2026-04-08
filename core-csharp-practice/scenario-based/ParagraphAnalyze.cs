using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2.Scenario: Create a program that analyzes a given paragraph of text. Implement the following
//functionalities:
//● Count the number of words in the paragraph.
//● Find and display the longest word.
//● Replace all occurrences of a specific word with another word (case-insensitive).
//● Handle edge cases like empty strings or paragraphs with only space

namespace BridgeLabzTraining.scenario_based
{
    internal class ParagraphAnalyze
    {
        // Method to remove extra spaces 
        static string RemoveExtraSpaces(string text)
        {
            
            string result = "";
            int i = 0;
            // Skip leading spaces
            while (i < text.Length && text[i] == ' ')
                i++;
            // false → a space is not yet added
            // true → a space was already added
            bool spaceFound = false;

            for (; i < text.Length; i++)
            {
                // check for space
                if (text[i] == ' ')
                {
                    // only one space is added
                    if (!spaceFound)
                    {
                        result += ' ';
                        spaceFound = true;
                    }
                }
                else
                {
                    // add non-space character
                    result += text[i];
                    spaceFound = false;
                }
            }

            // Remove trailing space if exists
            if (result.Length > 0 && result[result.Length - 1] == ' ')
                result = result.Substring(0, result.Length - 1);

            return result;
        }

        // Method to count words
        static int CountWords(string text)
        {
            // If text is empty
            if (text.Length == 0)
                return 0;

            // Initialize count to 1
            int count = 1;

            // Count spaces
            for (int i = 0; i < text.Length; i++)
            {
                // Increment count for each space
                if (text[i] == ' ')
                    count++;
            }

            return count;
        }

        // Method to find longest word
        static string FindLongestWord(string text)
        {
            
            string longest = "";
            string current = "";

            for (int i = 0; i < text.Length; i++)
            {
                // Build current word
                if (text[i] != ' ')
                {
                    // Add character to current word
                    current += text[i];
                }
                else
                {
                    // Check if current word is longest
                    if (current.Length > longest.Length)
                        longest = current;

                    current = "";
                }
            }

            // Last word check
            if (current.Length > longest.Length)
                longest = current;

            return longest;
        }

        // Method to compare words (case-insensitive)
        static bool IsSameWord(string w1, string w2)
        {
            // If lengths differ, words are not the same
            if (w1.Length != w2.Length)
                return false;

            for (int i = 0; i < w1.Length; i++)
            {
                // Compare characters case-insensitively
                char c1 = w1[i];
                char c2 = w2[i];

                // Convert to lowercase if uppercase
                if (c1 >= 'A' && c1 <= 'Z')
                    c1 = (char)(c1 + 32);

                // Convert to lowercase if uppercase
                if (c2 >= 'A' && c2 <= 'Z')
                    c2 = (char)(c2 + 32);

                // If characters differ, words are not the same
                if (c1 != c2)
                    return false;
            }

            return true;
        }

        // Method to replace word
        static string ReplaceWord(string text, string oldWord, string newWord)
        {
            string result = "";
            string current = "";

            for (int i = 0; i < text.Length; i++)
            {
                // Build current word
                if (text[i] != ' ')
                {
                    //  Add character to current word
                    current += text[i];
                }
                else
                {
                    // Check if current word matches oldWord
                    if (IsSameWord(current, oldWord))
                        result += newWord;
                    else
                        result += current;

                    result += ' ';
                    current = "";
                }
            }

            // Last word
            if (IsSameWord(current, oldWord))
                result += newWord;
            else
                result += current;

            return result;
        }

        static void Main()
        {
            // Input paragraph
            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            // Remove extra spaces
            paragraph = RemoveExtraSpaces(paragraph);

            // Handle empty paragraph
            if (paragraph.Length == 0)
            {
                Console.WriteLine("\nParagraph is empty or contains only spaces.");
                return;
            }

            // Count words and find longest word
            int wordCount = CountWords(paragraph);
            // Find longest word
            string longestWord = FindLongestWord(paragraph);

            // Display results
            Console.WriteLine("\nWord Count: " + wordCount);
            Console.WriteLine("Longest Word: " + longestWord);

            // old and new words for replacement
            Console.WriteLine("\nEnter word to replace:");
            string oldWord = Console.ReadLine();

            Console.WriteLine("Enter new word:");
            string newWord = Console.ReadLine();

            // Replace word
            paragraph = ReplaceWord(paragraph, oldWord, newWord);

            // Display updated paragraph
            Console.WriteLine("\nUpdated Paragraph:");
            Console.WriteLine(paragraph);
        }

    }
}

       