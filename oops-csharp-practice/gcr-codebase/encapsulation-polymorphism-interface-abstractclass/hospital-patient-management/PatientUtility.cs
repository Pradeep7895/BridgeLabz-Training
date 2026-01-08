using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.hospital_patient_management
{
    internal class PatientUtility
    {
        // Handles all patient-related operations

        private List<Patient> Patients = new List<Patient>();

        public void AddInPatient()
        {
            Console.Write("Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Days Admitted: ");
            int days = int.Parse(Console.ReadLine());

            Patients.Add(new InPatient(id, name, age, days));
            Console.WriteLine("In-Patient added.");
        }

        public void AddOutPatient()
        {
            Console.Write("Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Patients.Add(new OutPatient(id, name, age));
            Console.WriteLine("Out-Patient added.");
        }

        public void AddMedicalRecord()
        {
            Patient patient = FindPatient();
            if (patient is IMedicalRecord record)
            {
                Console.Write("Enter Medical Record: ");
                string data = Console.ReadLine();
                record.AddRecord(data);
                Console.WriteLine("Record added.");
            }
        }

        public void ViewMedicalRecords()
        {
            Patient patient = FindPatient();
            if (patient is IMedicalRecord record)
            {
                record.ViewRecords();
            }
        }

        public void DisplayBills()
        {
            foreach (Patient patient in Patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine("Bill Amount: ₹" + patient.CalculateBill());
                Console.WriteLine();
            }
        }

        private Patient FindPatient()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Patient p in Patients)
            {
                if (p.GetPatientId() == id)
                    return p;
            }

            Console.WriteLine("Patient not found.");
            return null;
        }

    }
}
