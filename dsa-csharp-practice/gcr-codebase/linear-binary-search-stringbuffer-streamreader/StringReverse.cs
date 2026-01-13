using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class StringReverse
    {
        static void Main()
        {
            Console.WriteLine("Enter String : ");
            string input = Console.ReadLine();

            //StringBuilder to store reversed string
            StringBuilder reversed = new StringBuilder(input.Length);

            // Loop from last character to first
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            // Convert StringBuilder to string
            Console.WriteLine("Reversed String: " + reversed.ToString());
        }

    }
}

  