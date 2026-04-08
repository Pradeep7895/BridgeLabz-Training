using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.shopping_cart
{
    internal class CartUtility
    {
        // Dictionary → product → price
        private Dictionary<string, double> products = new Dictionary<string, double>();

        // List → maintains insertion order (LinkedDictionary behavior)
        private List<string> insertionOrder = new List<string>();

        // Add product
        public void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            if (!products.ContainsKey(name))
            {
                products[name] = price;
                insertionOrder.Add(name);
                Console.WriteLine("Product added to cart.");
            }
            else
            {
                Console.WriteLine("Product already exists.");
            }
        }

        // Display cart in insertion order
        public void DisplayCart()
        {
            Console.WriteLine("\nCart Items (Insertion Order):");
            foreach (string name in insertionOrder)
                Console.WriteLine($"{name} : {products[name]}");
        }

        // Display cart sorted by price
        public void DisplaySortedByPrice()
        {
            Console.WriteLine("\nCart Items (Sorted by Price):");

            SortedDictionary<double, List<string>> sorted = new SortedDictionary<double, List<string>>();

            foreach (var item in products)
            {
                if (!sorted.ContainsKey(item.Value))
                    sorted[item.Value] = new List<string>();

                sorted[item.Value].Add(item.Key);
            }

            foreach (var priceGroup in sorted)
            {
                foreach (string name in priceGroup.Value)
                    Console.WriteLine($"{name} : {priceGroup.Key}");
            }
        }

        // Calculate total price
        public void DisplayTotal()
        {
            double total = 0;
            foreach (var price in products.Values)
                total += price;

            Console.WriteLine($"\nTotal Cart Value: {total}");
        }

    }
}

    