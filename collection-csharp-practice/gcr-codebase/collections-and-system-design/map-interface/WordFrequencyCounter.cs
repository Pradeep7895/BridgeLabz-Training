using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.map_interface
{
    internal class word_frequency_counter
    {
        static Dictionary<string, int> CountWordFrequency(string text)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            // Convert to lowercase
            text = text.ToLower();

            // Remove punctuation
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (map.ContainsKey(word))
                    map[word]++;
                else
                    map[word] = 1;
            }

            return map;
        }
        static void Main()
        {
            string text = "Hello world, hello Java!";

            Dictionary<string, int> frequency = CountWordFrequency(text);

            foreach (var pair in frequency)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }
}

    