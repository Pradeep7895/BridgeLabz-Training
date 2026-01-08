using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.hospital_patient_management
{
    internal class Menu
    {
        // Menu class only handles navigation
        private PatientUtility Utility = new PatientUtility();
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nHospital Patient Management : ");
                Console.WriteLine("1. Add In-Patient");
                Console.WriteLine("2. Add Out-Patient");
                Console.WriteLine("3. Add Medical Record");
                Console.WriteLine("4. View Medical Records");
                Console.WriteLine("5. Display Bills");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.AddInPatient();
                        break;
                    case 2:
                        Utility.AddOutPatient();
                        break;
                    case 3:
                        Utility.AddMedicalRecord();
                        break;
                    case 4:
                        Utility.ViewMedicalRecords();
                        break;
                    case 5:
                        Utility.DisplayBills();
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

