using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    internal class Car : Vehicle, IGPS
    {
        // Car vehicle

        private string CurrentLocation;

        public Car(int id, string driver)
            : base(id, driver, 15) { }

        public override double CalculateFare(double distance)
        {
            return distance * GetRatePerKm();
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string location)
        {
            CurrentLocation = location;
        }

    }
}


