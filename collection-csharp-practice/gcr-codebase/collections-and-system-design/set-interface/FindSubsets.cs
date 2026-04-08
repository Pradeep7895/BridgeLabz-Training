using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.set_interface
{
    internal class FindSubsets
    {
        static void Main()
        {
            HashSet<int> smallSet = new HashSet<int> { 2, 3 };
            HashSet<int> largeSet = new HashSet<int> { 1, 2, 3, 4 };

            bool isSubset = smallSet.IsSubsetOf(largeSet);

            Console.WriteLine(isSubset);
        }
    }
}
