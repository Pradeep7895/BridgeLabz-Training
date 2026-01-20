using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_proctor
{
    internal class StackLinkedList
    {
        private Node top;

        // Push operation
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        // Pop operation
        public int Pop()
        {
            if (top == null)
                return -1;

            int value = top.Data;
            top = top.Next;
            return value;
        }

        // Peek operation
        public int Peek()
        {
            return top == null ? -1 : top.Data;
        }

        // Check if empty
        public bool IsEmpty()
        {
            return top == null;
        }

    }
}

   