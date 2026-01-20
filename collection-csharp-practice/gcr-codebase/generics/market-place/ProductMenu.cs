using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.market_place
{
    internal class ProductMenu
    {
        MarketProductUtility utility = new MarketProductUtility();

        public void StartMenu()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Apply Discount");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Book\n2. Clothing");
                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        if (type == 1)
                            utility.AddProduct(new Product<Category>(name, price, new BookCategory()));
                        else
                            utility.AddProduct(new Product<Category>(name, price, new ClothingCategory()));
                        break;

                    case 2:
                        utility.ApplyDiscountToAll();
                        Console.WriteLine("Discount applied.");
                        break;

                    case 3:
                        utility.Display();
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
