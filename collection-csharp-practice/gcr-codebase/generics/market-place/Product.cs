using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.market_place
{
    internal class Product<T> where T : Category
    {
        private string productName;
        private double price;
        private T category;

        public Product(string name, double price, T category)
        {
            this.productName = name;
            this.price = price;
            this.category = category;
        }

        public void ApplyDiscount()
        {
            price = category.ApplyDiscount(price);
        }

        public override string ToString()
        {
            return $"Name: {productName}\nCategory: {category.Name}\nPrice: {price}\n";
        }
    }
}
