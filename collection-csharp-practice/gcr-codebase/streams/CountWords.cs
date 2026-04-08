using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.streams
{
    internal class CountWords
    {
        static void Main()
        {
            string basePath = @"D:\Collections\Collections\collection-csharp-practice\gcr-codebase\streams\";
            string filePath =basePath+ "input.txt";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                // Read file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split line into words
                        string[] words = line.Split(
                            new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?', '-', '"', '\'' },
                            StringSplitOptions.RemoveEmptyEntries
                        );

                        foreach (string word in words)
                        {
                            string key = word.ToLower();

                            if (wordCount.ContainsKey(key))
                                wordCount[key]++;
                            else
                                wordCount[key] = 1;
                        }
                    }
                }

                // Sort words by frequency (descending)
                var topWords = wordCount
                                .OrderByDescending(w => w.Value)
                                .Take(5);

                Console.WriteLine("Top 5 Most Frequent Words:\n");

                foreach (var word in topWords)
                {
                    Console.WriteLine($"{word.Key} -> {word.Value}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error occurred:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error:");
                Console.WriteLine(ex.Message);
            }
        }

    }
}

  