using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application
{
    internal class Bike : Vehicle , IRentable
    {
        //constructor for child class bike
        public Bike(int vehicleId, string brand, double rentPerDay)
            : base(vehicleId, brand, rentPerDay)
        {

        }

        //method to calculate rent
        public double CalculateRent(int days)
        {
            return rentPerDay * days;
        }

        //toString method to display details
        public override string ToString()
        {
            return base.ToString() +
                "\nVehicle Type: Bike";
        }
    }
}
