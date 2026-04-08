using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class RemoveDuplicates
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();

            foreach (char ch in input)
            {
                // If character is not already added
                if (!seen.Contains(ch))
                {
                    // Mark as seen
                    seen.Add(ch);
                    // Add to result
                    result.Append(ch);   
                }
            }

            Console.WriteLine("Result: " + result.ToString());
        }

    }
}

   