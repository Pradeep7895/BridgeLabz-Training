using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    // Abstract base class for all vehicles
    internal abstract class Vehicle
    {
        // Private instance variables
        private int VehicleId;
        private string DriverName;
        private double RatePerKm;

        protected Vehicle(int id, string driverName, double rate)
        {
            SetVehicleId(id);
            SetDriverName(driverName);
            SetRatePerKm(rate);
        }

        // Getter & Setter methods
        public int GetVehicleId()
        {
            return VehicleId;
        }

        private void SetVehicleId(int id)
        {
            VehicleId = id;
        }

        public string GetDriverName()
        {
            return DriverName;
        }

        private void SetDriverName(string name)
        {
            DriverName = name;
        }

        protected double GetRatePerKm()
        {
            return RatePerKm;
        }

        protected void SetRatePerKm(double rate)
        {
            RatePerKm = rate;
        }

        // Concrete method
        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}");
        }

        // Abstract method (POLYMORPHISM POINT)
        public abstract double CalculateFare(double distance);

    }
}


