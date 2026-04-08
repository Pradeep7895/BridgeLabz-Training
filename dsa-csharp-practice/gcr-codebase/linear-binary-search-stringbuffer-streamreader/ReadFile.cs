using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class ReadFile
    {
        static void Main()
        {
            // File path
            string filePath = "D:\\BridgeLabzTraining\\BridgeLabzTraining\\" +
                "dsa-csharp-practice\\gcr-codebase\\linear-binary-search-stringbuffer-" +
                "streamreader\\sample.txt";

            try
            {
                // StreamReader reads the file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Read until end of file
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

    }
}

   
