using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.employee_management_system
{
    internal class PartTimeEmployee : Employee, IDepartment
    {
        //instance members
        private int WorkHours;
        private double HourlyRate;
        private string Department;

        //constructor
        public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
        {
            WorkHours = hours;
            HourlyRate = rate;
        }
        //abstract method override
        public override double CalculateSalary()
        {
            return WorkHours * HourlyRate;
        }
        //assign department interface method override
        public void AssignDepartment(string departmentName)
        {
            Department = departmentName;
        }
        //get department details interface method override
        public string GetDepartmentDetails()
        {
            return Department;
        }
    }
}
