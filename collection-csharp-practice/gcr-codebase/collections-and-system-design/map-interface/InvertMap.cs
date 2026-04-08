using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.map_interface
{
    internal class InvertMap
    {
        static Dictionary<int, List<string>> InvertDictionary(Dictionary<string, int> map)
        {
            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            foreach (var pair in map)
            {
                int value = pair.Value;
                string key = pair.Key;

                if (!inverted.ContainsKey(value))
                    inverted[value] = new List<string>();

                inverted[value].Add(key);
            }

            return inverted;
        }
        static void Main()
        {
            Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            Dictionary<int, List<string>> inverted = InvertDictionary(input);

            foreach (var pair in inverted)
            {
                Console.Write(pair.Key + " = ");
                foreach (string value in pair.Value)
                    Console.Write(value + " ");
                Console.WriteLine();
            }
        }
    }
}

   