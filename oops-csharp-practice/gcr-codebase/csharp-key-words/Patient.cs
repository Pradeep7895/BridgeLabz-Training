using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_key_words
{
    internal class Patient
    {
        // static variable
        private static string HospitalName = "City Hospital";
        private static int totalPatients = 0;

        // readonly variable
        private readonly int PatientID;

        // instance variables
        private string Name;
        private int Age;
        private string Ailment;

        // constructor using this keyword
        public Patient(int PatientID, string Name, int Age, string Ailment)
        {
            this.PatientID = PatientID;
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            totalPatients++;
        }

        // static method to count total patients
        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients: " + totalPatients);
        }
        // is operator usage
        public static void DisplayPatient(object obj)
        {
            //using type casting
            if (obj is Patient p)
            {
                Console.WriteLine("\nHospital Name : " + HospitalName);
                Console.WriteLine("Patient ID  : " + p.PatientID);
                Console.WriteLine("Name  : " + p.Name);
                Console.WriteLine("Age : " + p.Age);
                Console.WriteLine("Ailment    : " + p.Ailment);
            }
            else
            {
                Console.WriteLine("Object is not a Patient");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Patient p1 = new Patient(1, "Pradeep", 22, "Fever");
            Patient p2 = new Patient(2, "Rahul", 20, "Cold");

            Patient.DisplayPatient(p1);
            Console.WriteLine();
            Patient.DisplayPatient(p2);
            Console.WriteLine();
            Patient.GetTotalPatients();

        }
    }
}
