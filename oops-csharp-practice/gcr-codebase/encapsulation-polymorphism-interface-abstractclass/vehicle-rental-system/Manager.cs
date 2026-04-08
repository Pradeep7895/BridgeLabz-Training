using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.vehicle_rental_system
{
    internal class Manager
    {
        
        public static void PrintRentalDetails(List<Vehicle> vehicles, int days)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                // Calculate rental cost (polymorphic call)
                double rentalCost = vehicle.CalculateRentalCost(days);

                double insuranceCost = 0;

                // Check if vehicle supports insurance
                if (vehicle is IInsurable insurableVehicle)
                {
                    insuranceCost = insurableVehicle.CalculateInsurance(days);
                }
                double totalCost = rentalCost + insuranceCost;

                // Display complete rental details
                Console.WriteLine(
                    $"{vehicle.GetType()} [{vehicle.GetVehicleNumber()}] | " +
                    $"Rental: {rentalCost}, Insurance: {insuranceCost}, Total: {totalCost}"
                );
            }
        }
    }
}
