using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.smart_warehouse
{
    internal class WarehouseUtility
    {
        public Storage<Electronics> electronicsStorage = new();
        public Storage<Groceries> groceriesStorage = new();
        public Storage<Furniture> furnitureStorage = new();


        public void AddElectronics()
        {
            Console.Write("Enter Item ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Warranty Years: ");
            int warranty = int.Parse(Console.ReadLine());

            Electronics electronics = new Electronics(id, name, warranty);
            electronicsStorage.AddItem(electronics);
        }

        public void AddGroceries()
        {
            Console.Write("Enter Item ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Expiry Date: ");
            string expiry = Console.ReadLine();

            Groceries groceries = new Groceries(id, name, expiry);
            groceriesStorage.AddItem(groceries);
        }

        public void AddFurniture()
        {
            Console.Write("Enter Item ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Material: ");
            string material = Console.ReadLine();

            Furniture furniture = new Furniture(id, name, material);
            furnitureStorage.AddItem(furniture);
        }
       
    }

}

