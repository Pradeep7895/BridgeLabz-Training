using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class SearchForSpecificWord
    {
        static void Main()
        {
            Console.Write("Enter number of sentences: ");
            int n = int.Parse(Console.ReadLine());

            string[] sentences = new string[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter sentence " + (i + 1) + ": ");
                sentences[i] = Console.ReadLine();
            }

            Console.Write("Enter word to search: ");
            string word = Console.ReadLine();

            
            FindSentence(sentences, word);
        }

        static void FindSentence(string[] sentences, string word)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {
                    Console.WriteLine("Word found in sentence: " + sentences[i]);
                    return;
                }
            }

            Console.WriteLine("Word not found in any sentence.");
        }

    }
}

   