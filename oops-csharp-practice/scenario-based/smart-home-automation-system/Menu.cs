using BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class Menu
    {
        private ApplianceUtility Utility = new ApplianceUtility();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nSmart Home Automation: ");
                Console.WriteLine("1. Add Light");
                Console.WriteLine("2. Add Fan");
                Console.WriteLine("3. Add AC");
                Console.WriteLine("4. Turn ON All Devices");
                Console.WriteLine("5. Turn OFF All Devices");
                Console.WriteLine("6. Turn ON Particular Device");   
                Console.WriteLine("7. Turn OFF Particular Device");  
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.AddLight();
                        break;
                    case 2:
                        Utility.AddFan();
                        break;
                    case 3:
                        Utility.AddAC();
                        break;
                    case 4:
                        Utility.TurnOnAll();
                        break;
                    case 5:
                        Utility.TurnOffAll();
                        break;
                    case 6:
                        Utility.TurnOnSpecific();
                        break;
                    case 7:
                        Utility.TurnOffSpecific();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }

        }

    }
}


        