using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.market_place
{
    internal class BookCategory : Category
    {
        public BookCategory()
        {
            Name = "Book";
        }

        public override double ApplyDiscount(double price)
        {
            // 10% book discount
            return price - (price * 10 / 100); 
        }
    }
}
