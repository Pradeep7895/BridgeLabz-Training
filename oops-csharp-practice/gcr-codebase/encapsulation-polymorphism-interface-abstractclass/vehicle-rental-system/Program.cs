using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal class Program
    {
        static void Main()
        {
            // list of vehicles
            List<Vehicle> vehicles = new List<Vehicle>();


            vehicles.Add(new Car("CAR343", 1500, "POL-CAR-01"));
            vehicles.Add(new Bike("BIKE385", 500, "POL-BIKE-02"));
            vehicles.Add(new Truck("TRUck37585", 3000, "POL-TRUCK-03"));

            // Calculate rental and insurance for 5 days
            Manager.PrintRentalDetails(vehicles, 5);
        }
    }
}
