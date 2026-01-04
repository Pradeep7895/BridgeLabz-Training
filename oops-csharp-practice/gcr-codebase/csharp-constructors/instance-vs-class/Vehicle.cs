using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.instance_vs_class
{
    internal class Vehicle
    {
        //instance variable
        private string ownerName;
        private string vehicleType;

        // Class variable 
        private static double registrationFee = 4000;

        // Constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        // Instance method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name  : " + ownerName);
            Console.WriteLine("Vehicle Type  : " + vehicleType);
            Console.WriteLine("Registration Fee  : " + registrationFee);
        }
        // Class method
        public static void UpdateRegistrationFee(double newFee)
        {
            if (newFee > 0)
            {
                registrationFee = newFee;
            }
        }

        // Main method
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Pradeep", "Car");
            Vehicle v2 = new Vehicle("Neha", "Bike");

            Console.WriteLine("Details Before Updation :\n");
            v1.DisplayVehicleDetails();
            Console.WriteLine();
            v2.DisplayVehicleDetails();

            //call class method 
            Console.WriteLine("\nUpdating Registration Fee...\n");
            Vehicle.UpdateRegistrationFee(5000);

            Console.WriteLine("Details After Updating Fee:\n");
            v1.DisplayVehicleDetails();
            Console.WriteLine();
            v2.DisplayVehicleDetails();
        }
    }
}
