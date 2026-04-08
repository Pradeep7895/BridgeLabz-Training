using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.e_commerce_platform
{
    internal class PriceCalculator
    {
        //list to add products
        public static void PrintFinalPrices(List<Product> products)
        {
            foreach (Product product in products)
            {
                double price = product.GetPrice();
                double discount = product.CalculateDiscount();
                double tax = 0;

                //is-a relation
                if (product is ITaxable taxableProduct)
                {
                    tax = taxableProduct.CalculateTax();
                }

                //find final price
                double finalPrice = price + tax - discount;

                Console.WriteLine(
                    $"{product.GetName()} | Final Price: {finalPrice}"
                );
            }
        }
    }
}
