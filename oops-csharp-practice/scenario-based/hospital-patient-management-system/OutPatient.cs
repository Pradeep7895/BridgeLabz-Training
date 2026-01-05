using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    internal class OutPatient : Patient , IPayable
    {
        private double consultationFee;
        private double testCharges;

        //constructor
        public OutPatient(int patientID, string patientName, int age, Doctor assignedDoctor, double consultationFee, double testCharges)
            : base(patientID, patientName, age, assignedDoctor)
        {
            this.consultationFee = consultationFee;
            this.testCharges = testCharges;
        }

        //getter and setter methods
        //for consulatation fee
        public double GetConsultationFee()
        {
            return consultationFee;
        }
        public void SetConsultationfee(double consultationFee)
        {
            this.consultationFee= consultationFee;  
        }

        //for testCharges
        public double GetTestCharges()
        {
            return testCharges;
        }
        public void SetTestCharges(double testCharges)
        {
            this.testCharges= testCharges;
        }

        //method to overrite calculateBill from interface
        public double CalculateBill()
        {
            return consultationFee + testCharges;
        }

        //tostring method
        public override string ToString()
        {
            return base.ToString()+"\n" +
                "Patient type : Out-patient\n" +
                $"Total Bill: {CalculateBill()}";
        }
    }
}
