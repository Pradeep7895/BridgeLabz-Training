using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery
{
    internal abstract class FoodItem
    {
        //Private instance variables
        private string ItemName;
        private double Price;
        private int Quantity;

        protected FoodItem(string name, double price, int quantity)
        {
            SetItemName(name);
            SetPrice(price);
            SetQuantity(quantity);
        }

        // Getter & Setter methods
        public string GetItemName()
        {
            return ItemName;
        }

        private void SetItemName(string name)
        {
            ItemName = name;
        }

        public double GetPrice()
        {
            return Price;
        }

        protected void SetPrice(double price)
        {
            Price = price;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        protected void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        // Abstract method
        public abstract double CalculateTotalPrice();

        // Concrete method
        public void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: {Price}, Quantity: {Quantity}");
        }
    }
}

    
