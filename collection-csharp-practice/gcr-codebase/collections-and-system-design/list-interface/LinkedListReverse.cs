using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.list_interface
{
    internal class LinkedListReverse
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            LinkedList<int> reversedList = ReversedLinkedList(list);

            Console.WriteLine("Reversed LinkedList: ");
            foreach (int item in reversedList)
            {
                Console.Write(item + " ");
            }
        }
        static LinkedList<int> ReversedLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversed = new LinkedList<int>();

            foreach (int item in list)
            {
                reversed.AddFirst(item);
            }
            return reversed;
        }
    }
}
