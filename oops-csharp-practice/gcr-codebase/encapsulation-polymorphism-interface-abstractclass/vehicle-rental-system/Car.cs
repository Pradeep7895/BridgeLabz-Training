using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal class Car : Vehicle, IInsurable
    {
        // Constructor for Car
        public Car(string number, double rate, string policyNumber)
            : base(number, "Car", rate, policyNumber) { }

        // Calculates rental cost for car
        public override double CalculateRentalCost(int days)
        {
            return GetRentalRate() * days;
        }

        // Calculates insurance cost for car
        public double CalculateInsurance(int days)
        {
            return days * 200; 
        }

        // Insurance description
        public string GetInsuranceDetails()
        {
            return "Car Insurance: ₹200 per day";
        }

    }
}
