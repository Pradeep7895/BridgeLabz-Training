using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.algorithm_and_big_o_notation
{
    internal class LargeFilesEfficiency
    {
        // Read file using StreamReader 
        static void ReadUsingStreamReader(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Read() != -1)
                {
                    // Reading character by character
                }
            }
        }

        // Read file using FileStream 
        static void ReadUsingFileStream(string filePath)
        {
            byte[] buffer = new byte[8192];

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    // Reading bytes in chunks
                }
            }
        }

        static void Main()
        {
            // Change this path to a real large file (1MB / 100MB / 500MB)
            string filePath = @"D:\BridgeLabzTraining\BridgeLabzTraining\dsa-csharp-practice\gcr-codebase\algorithm-and-big-o-notation\data_1MB.txt";

            Console.WriteLine("Large File Reading Performance\n");

            // StreamReader timing
            Stopwatch sw = Stopwatch.StartNew();
            ReadUsingStreamReader(filePath);
            sw.Stop();
            Console.WriteLine($"StreamReader Time: {sw.ElapsedMilliseconds} ms");

            // FileStream timing
            sw.Restart();
            ReadUsingFileStream(filePath);
            sw.Stop();
            Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds} ms");
        }

    }
}

