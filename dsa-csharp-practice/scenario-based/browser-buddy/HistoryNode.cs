using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    //Doubly linked list node
    internal class HistoryNode
    {
        public string Url;
        public HistoryNode Prev;
        public HistoryNode Next;

        public HistoryNode(string url)
        {
            Url = url;
            Prev = null;
            Next = null;
        }

    }
}

  
