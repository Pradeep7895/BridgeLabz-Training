using System;

namespace Collections.collection_csharp_practice.senario_based
{
    public class RobotHazardAuditor
    {
        public void Entry()
        {
            Console.WriteLine("Enter Arm Precision(0.0 - 1.0): ");
            double armPrecision = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Worker Density(1 - 20): ");
            int workerDensity = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Machinery State(Worn/Faulty/Critical): ");
            string machineryState = Console.ReadLine()!;

            if(armPrecision < 0.0 && armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
            }

            if(workerDensity <1 && workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }

            if(machineryState != "Worn" && machineryState != "Faulty" && machineryState != "Critical")
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }

            double hazardRisk = CalculateHazardRisk(armPrecision, workerDensity, machineryState);
            Console.WriteLine("Robot Hazard Risk Score : " + hazardRisk);
        }

        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            double machineRiskFactor = 0;
            switch (machineryState)
            {
                case "Worn":
                    machineRiskFactor = 1.3;
                    break;
                case "Faulty":
                    machineRiskFactor = 2.0;
                    break;    
                case "Critical":
                    machineRiskFactor = 3.0;
                    break;
            }

            double temp = ((1.0 - armPrecision)* 15.0) + (workerDensity * machineRiskFactor);
            return temp;
        }
    }
}