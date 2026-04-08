using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.e_commerce_platform
{
    internal class Program
    {
        static void Main()
        {
            //list of products
            List<Product> products = new List<Product>();

            products.Add(new Electronics(1, "Laptop", 60000));
            products.Add(new Clothing(2, "Jacket", 3000));
            products.Add(new Groceries(3, "Rice Bag", 1200));

            PriceCalculator.PrintFinalPrices(products);
        }
    }
}
