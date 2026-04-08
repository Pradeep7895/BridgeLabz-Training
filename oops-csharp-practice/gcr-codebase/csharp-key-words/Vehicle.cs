using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class Vehicle
    {
        // static variable
        private static double RegistrationFee = 4000;

        // readonly variable
        private readonly string RegistrationNumber;

        // instance variables
        private string OwnerName;
        private string VehicleType;

        // constructor using this keyword
        public Vehicle(string RegistrationNumber, string OwnerName, string VehicleType)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
        }


        // static method to update fee
        public static void UpdateRegistrationFee(double fee)
        {
            RegistrationFee = fee;
        }
        // is operator usage for checking vehicle object
        public static void DisplayVehicle(object obj)
        {
            //here use type casting 
            if (obj is Vehicle v)
            {
                Console.WriteLine("\nRegistration No : " + v.RegistrationNumber);
                Console.WriteLine("Owner Name      : " + v.OwnerName);
                Console.WriteLine("Vehicle Type    : " + v.VehicleType);
                Console.WriteLine("Fee             : " + RegistrationFee);
            }
            else
            {
                Console.WriteLine("Object is not a Vehicle");
            }
        }
    }

    class Program
    {
        static void Main()
        {
           //object creation
            Vehicle v1 = new Vehicle("UP85AB1234", "Pradeep", "Car");
            //before updation of fee
            Vehicle.DisplayVehicle(v1);

            Console.WriteLine();

            Vehicle.UpdateRegistrationFee(5000);
            //afteer updatinmg fee
            Vehicle.DisplayVehicle(v1);


        }
    }
}
