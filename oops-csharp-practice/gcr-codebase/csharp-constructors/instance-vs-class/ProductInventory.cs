using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.instance_vs_class
{
    internal class ProductInventory
    {
        //instance variables
        private string productName;
        private double price;

        //class variables
        private static int totalProducts = 0;

        //constructor
        public ProductInventory(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }
        
        //instance method 
        public void DisplayProductDetails()
        {
            
            Console.WriteLine("Product Name  : " + productName);
            Console.WriteLine("Price         : " + price);
            
        }
        //class method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total number of products: "  + totalProducts);
        }

        public static void Main()
        {
            //call instance methods
            ProductInventory product1 = new ProductInventory("Pen", 50);
            ProductInventory product2 = new ProductInventory("Pencil", 30);
            ProductInventory product3 = new ProductInventory("Eraser", 10);

            Console.WriteLine("Product 1 Details:");
            product1.DisplayProductDetails();

            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            product2.DisplayProductDetails();

            Console.WriteLine();

            Console.WriteLine("Product 3 Details:");
            product3.DisplayProductDetails();

            Console.WriteLine();

            //call class method
            ProductInventory.DisplayTotalProducts();
        }
    }
}
