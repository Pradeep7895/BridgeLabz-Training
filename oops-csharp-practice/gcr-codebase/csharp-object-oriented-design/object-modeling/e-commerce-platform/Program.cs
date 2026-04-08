using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.e_commerce_platform
{
    internal class Program
    {
        static void Main()
        {
            // Create customer
            Customer customer = new Customer("Rahul");

            // Create products
            Product p1 = new Product("Laptop", 60000);
            Product p2 = new Product("Mouse", 500);

            // Customer places an order
            Order order = customer.PlaceOrder();

            // Add products to order
            order.AddProduct(p1);
            order.AddProduct(p2);

            // Display order details
            order.ShowOrder();
        }
    }
}
