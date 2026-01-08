using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery
{
    internal class NonVegItem : FoodItem
    {
        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            // extra non-veg charge
            return (GetPrice() * GetQuantity()) + 100; 
        }

    }
}
