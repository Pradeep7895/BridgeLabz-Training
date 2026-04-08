using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.parcel_tracker
{
    internal class Menu
    {
        IParcel utility = new ParcelUtility();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("=======Parcel Tracking System======= ");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Add Stage");
                Console.WriteLine("3. Add Intermediate Checkpoint");
                Console.WriteLine("4. Track Parcel");
                Console.WriteLine("5. Handle Lost Parcel");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddOrder();
                        break;
                    case 2:
                        utility.AddStage();
                        break;
                    case 3:
                        utility.AddIntermediateStage();
                        break;
                    case 4:
                        utility.TrackParcel();
                        break;
                    case 5:
                        utility.LostParcel();
                        break;
                    case 0:
                        Console.WriteLine("Exit...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            } while (choice != 0);

        }
    }
}
