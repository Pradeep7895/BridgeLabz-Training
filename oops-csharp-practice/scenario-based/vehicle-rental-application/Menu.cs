using BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application
{
    internal class Menu
    {
        public void Start()
        {
            bool exit = false;
            Customer customer = new Customer(1, "Pradeep");

            while (!exit)
            {
                Console.WriteLine("\nVehicle Rental System : ");
                Console.WriteLine("1. Rent Bike");
                Console.WriteLine("2. Rent Car");
                Console.WriteLine("3. Rent Truck");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());
                IRentable rentable=null;
                Vehicle vehicle = null;

                switch (choice)
                {
                    case 1:
                        vehicle = new Bike(1, "Yamaha", 400);
                        rentable = (IRentable)vehicle;
                        break;
                    case 2:
                        vehicle = new Car(2, "Honda", 800);
                        rentable = (IRentable)vehicle;
                        break;
                    case 3:
                        vehicle = new Truck(3, "Tata", 1500);
                        rentable = (IRentable)vehicle;
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting system...");
                        continue;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;

                }
                Console.Write("Enter number of days: ");
                int days = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Customer Details: ");
                Console.WriteLine(customer);

                Console.WriteLine("Vehicle Details: ");
                Console.WriteLine(vehicle);

                Console.WriteLine($"\nTotal Rent: {rentable.CalculateRent(days)}");

            }
        }
    }
}

