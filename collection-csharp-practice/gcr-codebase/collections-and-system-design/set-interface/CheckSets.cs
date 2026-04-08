using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.set_interface
{
    internal class CheckSets
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

            bool result = AreSetsEqual(set1, set2);

            Console.WriteLine(result);
        }

        static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            // Step 1: Compare sizes
            if (set1.Count != set2.Count)
                return false;

            // Step 2: Check each element of set1 in set2
            foreach (int item in set1)
            {
                bool found = false;

                foreach (int element in set2)
                {
                    if (item == element)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    return false;
            }

            return true;
        }

    }
}

  