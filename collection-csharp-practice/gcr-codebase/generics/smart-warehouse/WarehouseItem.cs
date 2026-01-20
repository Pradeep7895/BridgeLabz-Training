using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse
{
    internal abstract class WarehouseItem
    {
        public int ItemId { get; protected set; }
        public string ItemName { get; protected set; }

        protected WarehouseItem(int itemId, string itemName)
        {
            ItemId = itemId;
            ItemName = itemName;
        }

        public abstract void Display();
    }
}
