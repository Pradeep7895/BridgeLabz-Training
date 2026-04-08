using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.e_commerce_platform
{
    // Aggregates multiple products
    internal class Order
    {
        // List of products in the order
        private List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

        // Add product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Display all products in the order
        public void ShowOrder()
        {
            Console.WriteLine("Order Details:");
            foreach (Product p in products)
                Console.WriteLine($"{p.Name} - {p.Price}");
        }
    }
}
