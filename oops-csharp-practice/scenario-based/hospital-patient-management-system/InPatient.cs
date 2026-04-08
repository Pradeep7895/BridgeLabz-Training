using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    internal class InPatient : Patient , IPayable
    {
        private int roomNumber;
        private int numberOfDays;
        private double dailyCharge;

        //constructor
        public InPatient(int patientID, string patientName, int age, Doctor assignedDoctor, int roomNumber, int numberOfDays, double dailyCharge)
            : base(patientID, patientName, age, assignedDoctor)
        {
            this.roomNumber = roomNumber;
            this.numberOfDays = numberOfDays;
            this.dailyCharge = dailyCharge;
        }

        //getter and setter methods
        //room number
        public int GetRoomNumber()
        {
            return roomNumber;
        }
        public void SetRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        //number of days
        public int GetNumberOfDays()
        {
            return numberOfDays;
        }
        public void SetNumberOfDays(int numberOfDays)
        {
            this.numberOfDays = numberOfDays;
        }
        //total charge
        public double GetDailyCharge()
        {
            return dailyCharge;
        }
        public void SetDailyCharge(int totalCharge)
        {
            this.dailyCharge = totalCharge;
        }

        //method to overrite calculatebill from interface
        public double CalculateBill()
        {
            return numberOfDays * dailyCharge;
        }

        //override tostring method
        public override string ToString()
        {
            return base.ToString()+"\n" +
                "Patient Type : In-patient\n" +
                $"Room number: {roomNumber}\n" +
                $"Number of days: {numberOfDays}\n" +
                $"Total Bill : {CalculateBill()}";
        }
    }
}
