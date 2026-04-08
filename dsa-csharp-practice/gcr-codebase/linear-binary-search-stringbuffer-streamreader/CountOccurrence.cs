using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class CountOccurrence
    {
        static void Main()
        {
            string filePath = "D:\\BridgeLabzTraining\\BridgeLabzTraining\\" +
                "dsa-csharp-practice\\gcr-codebase\\linear-binary-search-stringbuffer-" +
                "streamreader\\sample.txt";

            string searchWord = "hello";
            int count = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        if (word.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine($"The word '{searchWord}' appears {count} times.");
        }

    }
}

   