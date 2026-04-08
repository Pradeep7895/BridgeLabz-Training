using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    class StackNode
    {
        public Tab Data;
        public StackNode Next;

        public StackNode(Tab tab)
        {
            Data = tab;
            Next = null;
        }
    }

    class ClosedTabStack
    {
        private StackNode top;

        public void Push(Tab tab)
        {
            StackNode node = new StackNode(tab);
            node.Next = top;
            top = node;
        }

        public Tab Pop()
        {
            if (top == null)
                return null;

            Tab tab = top.Data;
            top = top.Next;
            return tab;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
