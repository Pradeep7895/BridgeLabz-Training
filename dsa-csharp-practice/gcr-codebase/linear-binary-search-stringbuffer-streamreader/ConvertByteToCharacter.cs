using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class ConvertByteToCharacter
    {
        static void Main()
        {
            string filePath = "D:\\BridgeLabzTraining\\BridgeLabzTraining\\" +
                "dsa-csharp-practice\\gcr-codebase\\linear-binary-search-stringbuffer-" +
                "streamreader\\data.bin";

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }

    }
}

   
