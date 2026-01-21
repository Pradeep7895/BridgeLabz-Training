using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.list_interface
{
    internal class FindNthElement
    {
        static string FindNthFromEnd(LinkedList<string> list, int n)
        {
            if (list.First == null)
                throw new Exception("List is Empty");

            LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;

            //move first pointer n steps ahead
            for(int i = 0; i < n; i++)
            {
                if (first == null)
                    throw new Exception("N is greater than list length");

                first = first.Next;
            }

            // Move both pointers until first reaches end
            while (first != null)
            {
                first = first.Next;
                second = second.Next;

            }
            return second.Value;
        }
        static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");

            int n = 2;

            string result = FindNthFromEnd(list, n);
            Console.WriteLine("Nth element from end: "+ result);
        }
    }
}
