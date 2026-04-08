using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    internal class RideUtility
    {

        // Handles ride operations

        private List<Vehicle> Vehicles = new List<Vehicle>();
        //method to add car in list
        public void AddCar()
        {
            Vehicles.Add(CreateVehicle("Car"));
            Console.WriteLine("Car added.");
        }
        //method to add bike in list 
        public void AddBike()
        {
            Vehicles.Add(CreateVehicle("Bike"));
            Console.WriteLine("Bike added.");
        }
        //method to add auto in list
        public void AddAuto()
        {
            Vehicles.Add(CreateVehicle("Auto"));
            Console.WriteLine("Auto added.");
        }

        //method to create vehicle
        private Vehicle CreateVehicle(string type)
        {
            Console.Write("Vehicle ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Driver Name: ");
            string driver = Console.ReadLine();

            if (type == "Car")
                return new Car(id, driver);

            if (type == "Bike")
                return new Bike(id, driver);

            return new Auto(id, driver);
        }

        // POLYMORPHIC METHOD
        public void CalculateFareForAll()
        {
            Console.Write("Enter distance (km): ");
            double distance = double.Parse(Console.ReadLine());

            foreach (Vehicle vehicle in Vehicles)
            {
                vehicle.GetVehicleDetails();

                // POLYMORPHISM → runtime method resolution
                double fare = vehicle.CalculateFare(distance);

                Console.WriteLine("Fare: " + fare);
                Console.WriteLine();
            }
        }

    }
}
