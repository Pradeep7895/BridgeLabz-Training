using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.market_place
{
    internal class MarketProductUtility
    {
        private List<Product<Category>> products = new List<Product<Category>>();

        public void AddProduct(Product<Category> product)
        {
            products.Add(product);
        }

        public void ApplyDiscountToAll()
        {
            foreach (var product in products)
            {
                product.ApplyDiscount();
            }
        }

        public void Display()
        {
            foreach (var product in products)
            {
                System.Console.WriteLine(product);
            }
        }
    }
}
