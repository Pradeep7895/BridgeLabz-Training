using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application
{
    internal class Vehicle
    {
        //protected fields
        protected int vehicleId;
        protected string brand; 
        protected double rentPerDay;

        //constructor
        public Vehicle(int vehicleId, string brand, double rentPerDay)
        {
            this.vehicleId = vehicleId;
            this.brand = brand;
            this.rentPerDay = rentPerDay;
        }
        //public methods for get and set
        //for vehicle id
        public int GetVehicleId()
        {
            return vehicleId;
        }
        public void SetVehicleId(int vehicleId)
        {
            this.vehicleId = vehicleId;
        }

        //for brand
        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        //for rent per day
        public double GetRentPerDay()
        {
            return rentPerDay;
        }
        public void SetRentPerDay(int rentPerDay)
        {
            this.rentPerDay = rentPerDay;
        }

        //to string methos to override
        public override string ToString()
        {
            return $"Vehicle ID : {vehicleId}\n" +
                   $"Brand : {brand}\n" +
                   $"Rent/Day : {rentPerDay}";
        }
    }
}
