using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery
{
    internal class VegItem : FoodItem, IDiscountable
    {
        // Veg food item

        public VegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return GetPrice() * GetQuantity();
        }

        public double ApplyDiscount()
        {
            return 50; // flat veg discount
        }

        public string GetDiscountDetails()
        {
            return "50 Veg Discount Applied";
        }

    }
}

