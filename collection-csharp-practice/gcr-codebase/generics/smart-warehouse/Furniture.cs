using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse
{
    internal class Furniture : WarehouseItem
    {
        public string Material { get; protected set; }

        public Furniture(int itemId, string itemName, string material)
            : base(itemId, itemName)
        {
            Material = material;
        }

        public override void Display()
        {
            Console.WriteLine(
                $"[Furniture] ID: {ItemId}, Name: {ItemName}, Material: {Material}");
        }
    }
}
