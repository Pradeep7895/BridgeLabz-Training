using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class Vehicle
    {
        // Attributes
        public int MaxSpeed;
        public string FuelType;

        // Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed: " + MaxSpeed);
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }
    // Subclass Car
    class Car : Vehicle
    {
        public int SeatCapacity;

        public override void DisplayInfo()
        {
            Console.WriteLine("Vehicle Type: Car");
            base.DisplayInfo();
            Console.WriteLine("Seat Capacity: " + SeatCapacity);
            Console.WriteLine();
        }
    }
    // Subclass Truck
    class Truck : Vehicle
    {
        public int PayloadCapacity;

        public override void DisplayInfo()
        {
            Console.WriteLine("Vehicle Type: Truck");
            base.DisplayInfo();
            Console.WriteLine("Payload Capacity: " + PayloadCapacity + " kg");
            Console.WriteLine();
        }
    }
    // Subclass Motorcycle
    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public override void DisplayInfo()
        {
            Console.WriteLine("Vehicle Type: Motorcycle");
            base.DisplayInfo();
            Console.WriteLine("Has Sidecar: " + HasSidecar);
            Console.WriteLine();
        }
    }
    // Main class
    class Program
    {
        static void Main()
        {
            // Polymorphism: Vehicle array 
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car
            {
                MaxSpeed = 180,
                FuelType = "Petrol",
                SeatCapacity = 5
            };

            vehicles[1] = new Truck
            {
                MaxSpeed = 120,
                FuelType = "Diesel",
                PayloadCapacity = 5000
            };
            vehicles[2] = new Motorcycle
            {
                MaxSpeed = 150,
                FuelType = "Petrol",
                HasSidecar = false
            };

            // Dynamic method dispatch
            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
            }
        }
    }
}
