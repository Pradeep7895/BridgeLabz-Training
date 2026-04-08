using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.linear_binary_search_stringbuffer_streamreader
{
    internal class ComaparePerformance
    {
        static void Main()
        {
            int count = 100000;

            // Using string concatenation
            Stopwatch sw1 = Stopwatch.StartNew();
            string text = "";

            for (int i = 0; i < count; i++)
            {
                text += "A";
            }
            sw1.Stop();

            // Using StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append("A");
            }
            sw2.Stop();

            Console.WriteLine("String (+) Time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
        }

    }
}

    