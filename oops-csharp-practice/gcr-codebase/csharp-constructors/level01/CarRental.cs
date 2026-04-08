using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level01
{
    internal class CarRental
    {
        // Private attributes
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double costPerDay = 1000;

        //default constructor
        public CarRental()
        {
            customerName = "Not Assign";
            carModel = "Standard";
            rentalDays = 1;
        }
        // Parameterized constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        // Method to calculate cost
        public double CalculateCost()
        {
            return rentalDays * costPerDay;
        }
        // Method to display details
        public void Display()
        {
            Console.WriteLine("Car Rental Details");
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Car Model     : " + carModel);
            Console.WriteLine("Rental Days   : " + rentalDays);
            Console.WriteLine("Total Cost    : " + CalculateCost());
        }
        public static void Main()
        {
            // Using default constructor
            CarRental rental1 = new CarRental();
            rental1.Display();

            Console.WriteLine();

            // Using parameterized constructor
            CarRental rental2 = new CarRental("Pradeep", "Creta", 4);
            rental2.Display();
        }
    }
}
