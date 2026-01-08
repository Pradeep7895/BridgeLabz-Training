using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    internal class Bike : Vehicle, IGPS
    {

        // Bike vehicle
        private string CurrentLocation;

        public Bike(int id, string driver)
            : base(id, driver, 10) { }

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
