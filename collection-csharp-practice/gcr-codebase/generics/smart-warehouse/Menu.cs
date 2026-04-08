using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse
{
    class Menu
    {
        private WarehouseUtility utility = new WarehouseUtility();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n==== Smart Warehouse Menu ====");
                Console.WriteLine("1. Add Electronics");
                Console.WriteLine("2. Add Groceries");
                Console.WriteLine("3. Add Furniture");
                Console.WriteLine("4. View Electronics");
                Console.WriteLine("5. View Groceries");
                Console.WriteLine("6. View Furniture");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        utility.AddElectronics(); 
                        break;
                    case 2:
                        utility.AddGroceries(); 
                        break;
                    case 3:
                        utility.AddFurniture(); 
                        break;
                    case 4: 
                        utility.electronicsStorage.DisplayAllItems(); 
                        break;
                    case 5:
                        utility.groceriesStorage.DisplayAllItems();
                        break;
                    case 6:
                        utility.furnitureStorage.DisplayAllItems(); 
                        break;
                    case 0:
                        return;
                    default: 
                        Console.WriteLine("Invalid choice"); 
                        break;
                }
            }
        }
    }

}
