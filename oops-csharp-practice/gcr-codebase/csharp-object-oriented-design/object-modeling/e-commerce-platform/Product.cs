using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.e_commerce_platform
{
    internal class Product
    {
        // Product name
        public string Name { get; private set; }

        // Product price
        public double Price { get; private set; }

        // Constructor to initialize product details
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
