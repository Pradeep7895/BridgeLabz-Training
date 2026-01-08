using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.singly_linkedlist.inventory_management_system
{
    internal class InventoryList
    {
        // Head points to first item
        private ItemNode head;

        // 1️. Add item at beginning
        public void AddAtBeginning(int id, string name, int qty, double price)
        {
            // Create new item
            ItemNode newNode = new ItemNode(id, name, qty, price);

            // New node points to old head
            newNode.Next = head;

            // Head moves to new node
            head = newNode;
        }

        // 2️. Add item at end
        public void AddAtEnd(int id, string name, int qty, double price)
        {
            ItemNode newNode = new ItemNode(id, name, qty, price);

            // If list is empty
            if (head == null)
            {
                head = newNode;
                return;
            }

            // Start from head
            ItemNode temp = head;

            // Move till last node
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            // Attach new node at end
            temp.Next = newNode;
        }

        // 3️.  Add item at specific position
        public void AddAtPosition(int position, int id, string name, int qty, double price)
        {
            // If position is first
            if (position == 1)
            {
                AddAtBeginning(id, name, qty, price);
                return;
            }

    
            ItemNode newNode = new ItemNode(id, name, qty, price);

            // Temporary node
            ItemNode temp = head;

            // Move to previous position
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            // If position is invalid
            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            // Insert item
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // 4️.  Remove item using Item ID
        public void RemoveByItemId(int id)
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            // If first item is to be removed
            if (head.ItemId == id)
            {
                head = head.Next;
                Console.WriteLine("Item removed");
                return;
            }

            // Temporary node
            ItemNode temp = head;

            // Search item
            while (temp.Next != null && temp.Next.ItemId != id)
            {
                temp = temp.Next;
            }

            // If item not found
            if (temp.Next == null)
            {
                Console.WriteLine("Item not found");
                return;
            }

            // Remove item
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed");
        }

        // 5️. Update quantity using Item ID
        public void UpdateQuantity(int id, int newQty)
        {
            // Start from head
            ItemNode temp = head;

            // Search item
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    // update quantity
                    temp.Quantity = newQty;
                    Console.WriteLine("Quantity updated");
                    return;
                }
                temp = temp.Next;
            }

            
            Console.WriteLine("Item not found");
        }

        // 6️.  Search item by Item ID
        public void SearchByItemId(int id)
        {
            // Start from head
            ItemNode temp = head;

            // Search item
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    PrintItem(temp);
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Item not found");
        }

        // 7️. Search item by Item Name
        public void SearchByItemName(string name)
        {
            ItemNode temp = head;
            bool found = false;

            // Traverse list
            while (temp != null)
            {
                if (temp.ItemName == name)
                {
                    PrintItem(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            // If item not found
            if (!found)
                Console.WriteLine("Item not found");
        }

        // 8️.  Calculate total inventory value
        public void CalculateTotalValue()
        {
            double total = 0;
            ItemNode temp = head;

            // Multiply price and quantity
            while (temp != null)
            {
                total = total + (temp.Price * temp.Quantity);
                temp = temp.Next;
            }

            Console.WriteLine("Total Inventory Value: " + total);
        }

        // 9️. Sort items by name
        public void SortByName(bool ascending)
        {
            // If list is empty
            if (head == null) return;

            // Simple bubble sort
            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if ((ascending && string.Compare(i.ItemName, j.ItemName) > 0) ||
                        (!ascending && string.Compare(i.ItemName, j.ItemName) < 0))
                    {
                        SwapData(i, j);
                    }
                }
            }
        }

        //10. Sort items by price
        public void SortByPrice(bool ascending)
        {
            // If list is empty
            if (head == null) return;

            // Simple bubble sort
            for (ItemNode i = head; i.Next != null; i = i.Next)
            {
                for (ItemNode j = i.Next; j != null; j = j.Next)
                {
                    if ((ascending && i.Price > j.Price) ||
                        (!ascending && i.Price < j.Price))
                    {
                        SwapData(i, j);
                    }
                }
            }
        }

        // Swap data of two nodes
        private void SwapData(ItemNode a, ItemNode b)
        {
            int id = a.ItemId;
            string name = a.ItemName;
            int qty = a.Quantity;
            double price = a.Price;

            a.ItemId = b.ItemId;
            a.ItemName = b.ItemName;
            a.Quantity = b.Quantity;
            a.Price = b.Price;

            b.ItemId = id;
            b.ItemName = name;
            b.Quantity = qty;
            b.Price = price;
        }

        // Display all items
        public void DisplayAll()
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            ItemNode temp = head;

            // Traverse and print items
            while (temp != null)
            {
                PrintItem(temp);
                temp = temp.Next;
            }
        }

        // Print one item
        private void PrintItem(ItemNode i)
        {
            Console.WriteLine(
                "ID: " + i.ItemId +
                ", Name: " + i.ItemName +
                ", Quantity: " + i.Quantity +
                ", Price: " + i.Price
            );
        }

    }
}

   