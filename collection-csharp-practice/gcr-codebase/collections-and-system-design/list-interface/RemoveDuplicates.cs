using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.list_interface
{
    internal class RemoveDuplicates
    {
        static List<int> RemoveDuplicatesPreserveOrder(List<int> list)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int item in list)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    result.Add(item);
                }
            }

            return result;
        }
        static void Main()
        {
            List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };

            List<int> result = RemoveDuplicatesPreserveOrder(list);

            foreach (int item in result)
                Console.Write(item + " ");
        }
    }
}
