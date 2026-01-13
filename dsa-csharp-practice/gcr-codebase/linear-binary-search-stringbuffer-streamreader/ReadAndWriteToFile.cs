using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class ReadAndWriteToFile
    {
        static void Main()
        {
            string filePath = "D:\\BridgeLabzTraining\\BridgeLabzTraining\\" +
                "dsa-csharp-practice\\gcr-codebase\\linear-binary-search-stringbuffer-" +
                "streamreader\\output.txt";

            Console.Write("Enter text to write to file: ");
            string input = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Data written to file successfully.");
        }

    }
}

 
