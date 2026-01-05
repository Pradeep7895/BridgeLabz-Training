using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vehicle_rental_application
{
    internal class Car : Vehicle , IRentable
    {
        //constructor for child class car
        public Car(int id, string brand, double rentPerDay)
           : base(id, brand, rentPerDay)
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
            return base.ToString() + "\nVehicle Type: Car";
        }
    }
}
