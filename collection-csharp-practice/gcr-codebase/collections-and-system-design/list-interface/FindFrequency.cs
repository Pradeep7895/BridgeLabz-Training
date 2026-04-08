using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.list_interface
{
    internal class FindFrequency
    {
        static Dictionary<string,int> FrequencyOfElements(List<string> input)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach(string s in input)
            {
                if (freq.ContainsKey(s))
                {
                    freq[s]++;
                }
                else
                {
                    freq[s] = 1;
                }
            }
            return freq;
        }

        static void Main()
        {
            List<string> input = new List<string>()
            {
                "apple", "banana", "apple", "orange"
            };
            Dictionary<string, int> frequency = FrequencyOfElements(input);

            foreach (var item in frequency)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
