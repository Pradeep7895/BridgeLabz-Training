using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    internal class Doctor
    {
        private int doctorID;
        private string doctorName;
        private string speciality;
        

        //constructor
        public Doctor(int doctorID, string doctorName, string speciality)
        {
            this.doctorID = doctorID;
            this.doctorName = doctorName;
            this.speciality = speciality;
            
        }

        //method to get and set doctorID 
        public int GetDoctorID()
        {
            return doctorID;
        }
        public void SetDoctorID(int doctorID)
        {
            this.doctorID = doctorID;
        }

        //method to get and set doctorName
        public string GetDoctorName()
        {
            return doctorName;
        }
        public void SetDoctorName(string doctorName)
        {
            this.doctorName = doctorName;
        }


        //methods for get and set doctor's speciality
        public string GetSpeciality()
        {
            return speciality;
        }
        public void SetSpeciality(string speciality)
        {
            this.speciality = speciality;
        }

        //override to string method
        public override string ToString()
        {
            return "\n"+
                $"Doctor Id : {doctorID}\n" +
                $"Doctor Name : {doctorName}\n" +
                $"Speciality : {speciality}";
        }
    }
}
