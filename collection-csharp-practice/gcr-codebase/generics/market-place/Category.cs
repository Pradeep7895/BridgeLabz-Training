using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.market_place
{
    internal abstract class Category
    {
        public string Name { get; protected set; }

        public abstract double ApplyDiscount(double price);
    }
}
