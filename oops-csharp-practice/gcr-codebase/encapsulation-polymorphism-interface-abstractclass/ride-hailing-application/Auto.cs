using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    internal class Auto : Vehicle, IGPS
    {
        // Auto vehicle

        private string CurrentLocation;

        public Auto(int id, string driver)
            : base(id, driver, 12) { }

        public override double CalculateFare(double distance)
        {
            // base charge
            return (distance * GetRatePerKm()) + 20; 
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

