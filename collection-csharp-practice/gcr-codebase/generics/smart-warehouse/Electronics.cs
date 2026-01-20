using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse
{
    internal class Electronics : WarehouseItem
    {
        public int WarrantyYears { get; protected set; }

        public Electronics(int itemId, string itemName, int warrantyYears)
            : base(itemId, itemName)
        {
            WarrantyYears = warrantyYears;
        }

        public override void Display()
        {
            Console.WriteLine(
                $"[Electronics] ID: {ItemId}, Name: {ItemName}, Warranty: {WarrantyYears} years");
        }

    }
}
