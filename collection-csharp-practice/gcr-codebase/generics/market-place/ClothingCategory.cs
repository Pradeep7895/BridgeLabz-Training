using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.market_place
{
    internal class ClothingCategory : Category
    {
        public ClothingCategory()
        {
            Name = "Clothing";
        }

        public override double ApplyDiscount(double price)
        {
            // 20% clothing discount
            return price - (price * 20 / 100); 
        }
    }
}
