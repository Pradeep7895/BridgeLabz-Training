using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_management_system
{
    internal class Employee
    {
        //member variables
        private int EmployeeId;
        private string EmployeeName;
        private bool IsPresent;
        private double DailyWage;
        private double PartTimeWage;
        private int PresentDays;
        private double MonthlyWage;
        


        //public getter and setter methods
        public int GetEmployeeId() { return EmployeeId; }
        public void SetEmployeeId(int EmployeeId) { this.EmployeeId = EmployeeId; }

        public string GetEmployeeName() { return EmployeeName; }
        public void SetEmployeeName(string EmployeeName) { this.EmployeeName = EmployeeName; }

   
        public bool GetIsPresent() { return IsPresent; }
        public void SetIsPresent(bool IsPresent) { this.IsPresent = IsPresent; }

        public double GetDailyWage() { return DailyWage; }
        public void SetDailyWage(double DailyWage) { this.DailyWage = DailyWage; }

        public double GetPartTimeWage() { return PartTimeWage; }
        public void SetPartTimeWage(double PartTimeWage) { this.PartTimeWage = PartTimeWage; }


        public int GetPresentDays() { return PresentDays; }
        public void SetPresentDays(int PresentDays) { this.PresentDays = PresentDays; }

        public double GetMonthlyWage() { return MonthlyWage; }
        public void SetMonthlyWage(double MonthlyWage) { this.MonthlyWage = MonthlyWage; }

        public override string ToString()
        {
            return $"Employee Id = {EmployeeId}\n" +
                $"Employee Name = {EmployeeName}\n" +
                $"Attendance = {(IsPresent ? "Present" : "Absent")}\n" +
                $"Daily Wage : {DailyWage}\n" +
                $"PartTime wage : {PartTimeWage}\n"+
                $"Present Days : {PresentDays}\n" +
                $"Monthly Wage : {MonthlyWage}";
        }
    }
}
