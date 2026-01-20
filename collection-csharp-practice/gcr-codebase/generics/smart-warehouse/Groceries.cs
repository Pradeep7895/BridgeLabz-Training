using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse
{
    internal class Groceries : WarehouseItem
    {
        public string ExpiryDate { get; protected set; }

        public Groceries(int itemId, string itemName, string expiryDate)
            : base(itemId, itemName)
        {
            ExpiryDate = expiryDate;
        }

        public override void Display()
        {
            Console.WriteLine(
                $"[Groceries] ID: {ItemId}, Name: {ItemName}, Expiry: {ExpiryDate}");
        }
    }
}
