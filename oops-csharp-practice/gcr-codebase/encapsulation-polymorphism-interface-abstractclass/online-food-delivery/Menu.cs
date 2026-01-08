using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.online_food_delivery
{
    internal class Menu
    {
        private FoodUtility Utility = new FoodUtility();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nOnline Food Delivery : ");
                Console.WriteLine("1. Add Veg Item");
                Console.WriteLine("2. Add Non-Veg Item");
                Console.WriteLine("3. Show Bill");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.AddVegItem();
                        break;
                    case 2:
                        Utility.AddNonVegItem();
                        break;
                    case 3:
                        Utility.ShowBill();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

    }
}

   