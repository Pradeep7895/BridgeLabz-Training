using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    internal class Menu
    {
        public void Start()
        {
            Doctor doctor1 = new Doctor(1, "Dr. Pradeep Chaudhary", "MBBS");
            Doctor doctor2 = new Doctor(2, "Dr. Abhay Pratap", "MD");

            Bill bill = new Bill();
            Patient patient=null;

            int choice;
            Console.WriteLine("Patient Tpye\n");
            Console.WriteLine("1. In-patient");
            Console.WriteLine("2. Out-patient");
            
            Console.WriteLine("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    patient = new InPatient(1, "Ojas", 21, doctor1, 201, 4, 2000);
                    
                    break;
                case 2:
                    patient = new OutPatient(2, "Abhishek", 22, doctor2, 500, 1000);
                    break;
            }
            Console.WriteLine("\nPatient Details: ");
            Console.WriteLine(patient);

            Console.WriteLine("\nBilling: ");
            Console.WriteLine(bill.GenerateBill((IPayable)patient));


        }
    }
}
