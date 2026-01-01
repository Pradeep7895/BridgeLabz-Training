using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class CafeteriaMenu
    {
        //items list
        static string[] items =
        {
            "Cheese Burger", "Veg Sandwich", "Pasta", "Fried Rice", "Pizza Slice",
            "Coffee", "Tea", "Cold Drink", "French Fries","Ice Cream"
        };
        //ittems price 
        static double[] prices =
        {
            60,80,120,70,160,
            100,20,20,40,30
        };

        //Display menu
        public void Display()
        {
            Console.WriteLine("Menu: ");
            for(int i=0;i<items.Length;i++)
            {
                Console.WriteLine( $"{i} : {items[i]} - INR{prices[i]} ");
            }
        }

        //get item by index
        public string GetItemByIndex(int index)
        {
            //check if index is valid
            if (index >=0 || index < items.Length)
            {
                return items[index];
            }

            return null;
        }

        //get price by index
        public double GetItemValue(int index)
        {
            //check if index is valid
            if ( index >=0 || index < items.Length)
            {
                return prices[index];
            }
            return 0;
        }
       
    }
}

  
        

