using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.list_interface
{
    internal class ArrayListReverse
    {
        static void ReversedArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;

            }
        }

        static void Main()
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

            ReversedArrayList(list);

            Console.WriteLine("Reversed ArrayList: ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
