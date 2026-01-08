using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.hospital_patient_management
{
    internal class InPatient : Patient, IMedicalRecord
    {
        private List<string> MedicalHistory = new List<string>();
        private int DaysAdmitted;

        public InPatient(int id, string name, int age, int days)
            : base(id, name, age)
        {
            DaysAdmitted = days;
        }

        public override double CalculateBill()
        {
            // per day charge
            return DaysAdmitted * 3000; 
        }

        public void AddRecord(string record)
        {
            MedicalHistory.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (string record in MedicalHistory)
            {
                Console.WriteLine("- " + record);
            }
        }

    }
}

    