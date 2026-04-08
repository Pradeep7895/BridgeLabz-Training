using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.hospital_patient_management
{
    internal class OutPatient : Patient, IMedicalRecord
    {

        // OutPatient visits hospital once

        private List<string> MedicalHistory = new List<string>();

        public OutPatient(int id, string name, int age)
            : base(id, name, age) { }

        public override double CalculateBill()
        {
            // consultation fee
            return 800; 
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

