using System;

//detect and remove cycle from the linked list without loosing the nodes

namespace BridgeLabzTraining.review.dsa_review
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;

        }
    }
    
    class LinkedList
    {
        public static void DetectAndRemove(Node head)
        {
            if (head == null || head.Next == null)
            {
                return;
            }
            Node fast = head, slow = head;

            //detect loop
            while (fast != null || fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    break;
            }
            //no loop detect
            if (slow != fast)
                return;

            //now we find the start of loop
            slow = head;
            while(slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            //starting node from slow == fast
            Node start = slow;

            //remove loop
            while(start.Next != slow)
            {
                start = start.Next;
            }
            start.Next = null;
        }
    }
}


