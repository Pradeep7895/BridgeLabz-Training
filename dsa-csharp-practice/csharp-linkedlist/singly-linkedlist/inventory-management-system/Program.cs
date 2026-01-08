using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.inventory_management_system
{
    internal class Program
    {
        static void Main()
        {
            // Create inventory object
            InventoryList inventory = new InventoryList();

            // Add items
            inventory.AddAtBeginning(1, "Pen", 50, 10);
            inventory.AddAtEnd(2, "Notebook", 20, 50);
            inventory.AddAtEnd(3, "Pencil", 100, 5);

            // Display items
            inventory.DisplayAll();

            // Update quantity
            inventory.UpdateQuantity(3, 150);

            // Search item
            inventory.SearchByItemId(2);

            // Calculate total value
            inventory.CalculateTotalValue();

            // Sort by price
            inventory.SortByPrice(true);

            // Display again
            inventory.DisplayAll();
        }

    }
}

   