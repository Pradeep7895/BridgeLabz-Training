using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class StringConcatenate
    {
        static void Main()
        {
            Console.Write("Enter number of strings: ");
            int count = int.Parse(Console.ReadLine());

            // StringBuilder 
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Enter string " + i + ": ");
                string input = Console.ReadLine();

                // Append user input to StringBuilder
                sb.Append(input);
            }

            // Display final concatenated string
            Console.WriteLine("\nFinal String: " + sb.ToString());
        }

    }
}

    