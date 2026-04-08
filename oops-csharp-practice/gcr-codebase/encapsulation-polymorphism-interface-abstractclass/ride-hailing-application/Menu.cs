using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    internal class Menu
    {
        // Menu handles only navigation

        private RideUtility Utility = new RideUtility();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n Ride-Hailing Application : ");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Add Bike");
                Console.WriteLine("3. Add Auto");
                Console.WriteLine("4. Calculate Fare ");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.AddCar();
                        break;
                    case 2:
                        Utility.AddBike();
                        break;
                    case 3:
                        Utility.AddAuto();
                        break;
                    case 4:
                        Utility.CalculateFareForAll();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

    }
}

