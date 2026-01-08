using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.inventory_management_system
{
    internal class ItemNode
    {
        //item details
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;

        // Link to next item
        public ItemNode Next;

        // Constructor to assign values
        public ItemNode(int id, string name, int qty, double price)
        {
            ItemId = id;
            ItemName = name;
            Quantity = qty;
            Price = price;
            Next = null;
        }

    }
}

   