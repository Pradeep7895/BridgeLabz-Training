using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery
{
    internal class FoodUtility
    {
        private List<FoodItem> Orders = new List<FoodItem>();

        public void AddVegItem()
        {
            Orders.Add(CreateItem(true));
            Console.WriteLine("Veg item added.");
        }

        public void AddNonVegItem()
        {
            Orders.Add(CreateItem(false));
            Console.WriteLine("Non-Veg item added.");
        }

        private FoodItem CreateItem(bool isVeg)
        {
            Console.Write("Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (isVeg)
                return new VegItem(name, price, quantity);

            return new NonVegItem(name, price, quantity);
        }

        public void ShowBill()
        {
            double grandTotal = 0;

            foreach (FoodItem item in Orders)
            {
                item.GetItemDetails();

                double total = item.CalculateTotalPrice();
                double discount = 0;

                if (item is IDiscountable discountable)
                {
                    discount = discountable.ApplyDiscount();
                    Console.WriteLine(discountable.GetDiscountDetails());
                }

                double finalPrice = total - discount;
                Console.WriteLine("Final Price: " + finalPrice);
                

                grandTotal += finalPrice;
            }

            Console.WriteLine("Grand Total: " + grandTotal);
        }

    }
}

   