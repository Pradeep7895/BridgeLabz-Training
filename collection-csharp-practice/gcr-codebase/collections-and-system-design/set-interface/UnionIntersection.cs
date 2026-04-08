using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.set_interface
{
    internal class UnionIntersection
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            // Union
            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);

            // Intersection
            HashSet<int> intersection = new HashSet<int>(set1);
            intersection.IntersectWith(set2);

            Console.WriteLine("Union:");
            foreach (int x in union)
                Console.Write(x + " ");

            Console.WriteLine("\nIntersection:");
            foreach (int x in intersection)
                Console.Write(x + " ");
        }

    }
}

  