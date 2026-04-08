using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.set_interface
{
    internal class SymmetricDifference
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            HashSet<int> result = new HashSet<int>(set1);
            result.SymmetricExceptWith(set2);

            foreach (int x in result)
                Console.Write(x + " ");
        }
    }
}
