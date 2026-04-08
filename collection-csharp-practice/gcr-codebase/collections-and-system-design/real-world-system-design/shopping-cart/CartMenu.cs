using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.shopping_cart
{
    internal class CartMenu
    {
        private CartUtility utility = new CartUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n==== Shopping Cart Menu ====");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Cart (Insertion Order)");
                Console.WriteLine("3. View Cart (Sorted by Price)");
                Console.WriteLine("4. View Total Amount");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddProduct();
                        break;

                    case 2:
                        utility.DisplayCart();
                        break;

                    case 3:
                        utility.DisplaySortedByPrice();
                        break;

                    case 4:
                        utility.DisplayTotal();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Shopping Cart...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}

    