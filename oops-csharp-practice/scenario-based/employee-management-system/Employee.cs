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
        private double EmployeeSalary;
        private string EmployeeNumber;
        private string EmployeeEmail;
        private bool IsPresent;

        //public getter and setter methods
        public int GetEmployeeId() { return EmployeeId; }
        public void SetEmployeeId(int EmployeeId) { this.EmployeeId = EmployeeId; }

        public string GetEmployeeName() { return EmployeeName; }
        public void SetEmployeeName(string EmployeeName) { this.EmployeeName = EmployeeName; }

        public double GetEmployeeSalary() { return EmployeeSalary; }
        public void SetEmployeeSalary(double EmployeeSalary) { this.EmployeeSalary = EmployeeSalary; }

        public string GetEmployeeEmail() { return EmployeeEmail; }
        public void SetEmployeeEmail(string EmployeeEmail) { this.EmployeeEmail = EmployeeEmail; }

        public bool GetIsPresent() { return IsPresent; }
        public void SetIsPresent(bool IsPresent) { this.IsPresent = IsPresent; }

        public override string ToString()
        {
            return $"Employee Id = {EmployeeId}\n" +
                $"Employee Name = {EmployeeName}\n" +
                $"Attendence : {(IsPresent ? "Present" : "Absent")}";
                
             

        }
    }
}
