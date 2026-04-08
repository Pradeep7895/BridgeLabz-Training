using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.e_commerce_platform
{
    internal class Customer
    {
        // Customer name
        public string Name { get; private set; }

        // Constructor to initialize customer
        public Customer(string name)
        {
            Name = name;
        }

        // Customer creates a new order
        public Order PlaceOrder()
        {
            return new Order();
        }
    }
}
