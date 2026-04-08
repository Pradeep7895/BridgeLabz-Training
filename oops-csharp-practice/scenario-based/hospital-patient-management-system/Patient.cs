using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    internal class Patient
    {
        //instance variables
        private int patientID;
        private string patientName;
        private int age;
        private Doctor assignedDoctor;


        //constructor
        public Patient(int patientID, string patientName, int age, Doctor assignedDoctor)
        {
            this.patientID = patientID;
            this.patientName = patientName;
            this.age = age;
            this.assignedDoctor = assignedDoctor;
        }
        //methods to get nd set patientid
        public int GetPatientID()
        {
            return patientID;
        }
        public void SetPatientID(int patientID)
        {
            this.patientID = patientID;
        }

        //methods to get and set patient name
        public string GetPatientName()
        {
            return patientName;
        }
        public void SetPatientName(string patientName)
        {
            this.patientName = patientName;
        }

        //methods to get and set patient disease
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        //method to get and set doctor
        public Doctor GetDoctor()
        {
            return assignedDoctor;
        }
        public void SetDoctor(Doctor assignedDoctor)
        {
            this.assignedDoctor = assignedDoctor;
        }

        //toString method for overriding
        public override string ToString()
        {
            return 
                $"Patient ID: {patientID}\n" +
                $"Patient Name: {patientName}\n" +
                $"Age: {age} {assignedDoctor}";
        }
    }
}
