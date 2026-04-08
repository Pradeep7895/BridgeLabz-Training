using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    //custom doubly linked list
    internal class HistoryManager
    {
        private HistoryNode head;
        private HistoryNode tail;
        private HistoryNode current;

        // Visit new page
        public void VisitPage(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            if (head == null)
            {
                head = tail = current = newNode;
            }
            else
            {
                // Clear forward history
                current.Next = null;
                tail = current;

                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
                current = newNode;
            }

            Console.WriteLine("Visited: " + url);
        }

        public void GoBack()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        public void GoForward()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No forward page.");
            }
        }

        public string GetCurrentPage()
        {
            return current != null ? current.Url : "No page";
        }

    }
}

  