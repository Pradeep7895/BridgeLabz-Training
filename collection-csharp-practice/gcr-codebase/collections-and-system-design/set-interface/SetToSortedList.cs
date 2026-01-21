using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.set_interface
{
    internal class SetToSortedList
    {
        static void Main()
        {
            HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

            List<int> list = new List<int>(set);
            list.Sort();   

            foreach (int x in list)
                Console.Write(x + " ");
        }
    }
}
