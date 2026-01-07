using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal abstract class Vehicle
    {
        //instance variables
        private string VehicleNumber;
        private string Type;
        private double RentalRate;
        private string InsurancePolicyNumber;

        // Constructor 
        protected Vehicle(string number, string type, double rate, string policyNumber)
        {
            SetVehicleNumber(number);
            SetType(type);
            SetRentalRate(rate);
            SetInsurancePolicyNumber(policyNumber);

        }
        // Getter an setter for vehicle number
        public string GetVehicleNumber()
        {
            return VehicleNumber;
        }
        private void SetVehicleNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Vehicle number cannot be empty.");
            VehicleNumber = number;
        }

        // Getter and setter for vehicle type
        public string GetType()
        {
            return Type;
        }
        private void SetType(string type)
        {
            Type = type;
        }

        // Getter for rental rate
        public double GetRentalRate()
        {
            return RentalRate;
        }
        // Protected setter so only subclasses can change it
        protected void SetRentalRate(double rate)
        {
            if (rate <= 0)
                throw new ArgumentException("Rental rate must be positive.");
            RentalRate = rate;
        }

        // Protected getter for insurance policy number
        protected string GetInsurancePolicyNumber()
        {
            return InsurancePolicyNumber;
        }
        // Private setter to prevent external modification
        private void SetInsurancePolicyNumber(string policy)
        {
            InsurancePolicyNumber = policy;
        }

        // Abstract method to Calculates rental cost 
        public abstract double CalculateRentalCost(int days);
    }
}
