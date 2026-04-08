using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.hospital_patient_management
{
    // Abstract base class for all patients
    internal abstract class Patient
    {
        //Private instance variables
        private int PatientId;
        private string Name;
        private int Age;

        // Sensitive data (encapsulated)
        private string Diagnosis;

        protected Patient(int id, string name, int age)
        {
            SetPatientId(id);
            SetName(name);
            SetAge(age);
        }

        // Getter & Setter methods
        public int GetPatientId()
        {
            return PatientId;
        }

        private void SetPatientId(int id)
        {
            PatientId = id;
        }

        public string GetName()
        {
            return Name;
        }

        private void SetName(string name)
        {
            Name = name;
        }

        public int GetAge()
        {
            return Age;
        }

        private void SetAge(int age)
        {
            Age = age;
        }

        // Protected methods for sensitive data
        protected void SetDiagnosis(string diagnosis)
        {
            Diagnosis = diagnosis;
        }

        protected string GetDiagnosis()
        {
            return Diagnosis;
        }

        // Concrete method
        public void GetPatientDetails()
        {
            Console.WriteLine($"ID: {PatientId}, Name: {Name}, Age: {Age}");
        }

        // Abstract method
        public abstract double CalculateBill();

    }
}


