using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class Product
    {
        // static variable 
        private static double Discount = 10;

        // readonly variable
        private readonly int ProductID;

        // instance variables
        private string ProductName;
        private double Price;
        private int Quantity;

        // constructor using this keyword
        public Product(int ProductID, string ProductName, double Price, int Quantity)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        //static method to update discount
        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }
        // is operator usage
        public static void DisplayProduct(object obj)
        {
            if (obj is Product )
            {
                Product p = (Product)obj;
                Console.WriteLine("\nProduct ID   : " + p.ProductID);
                Console.WriteLine("Name         : " + p.ProductName);
                Console.WriteLine("Price        : " + p.Price);
                Console.WriteLine("Quantity     : " + p.Quantity);
                Console.WriteLine("Discount (%) : " + Discount);
            }
            else
            {
                Console.WriteLine("Object is not a Product");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            //object 
            Product p1 = new Product(1, "Laptop", 60000, 1);

            Product.DisplayProduct(p1);

            Console.WriteLine();

            Console.WriteLine("\nUpdating Discount...\n");
            Product.UpdateDiscount(15);

            Product.DisplayProduct(p1);


        }
    }
}
