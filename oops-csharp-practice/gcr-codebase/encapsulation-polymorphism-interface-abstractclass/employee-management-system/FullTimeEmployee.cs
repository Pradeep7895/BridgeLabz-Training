using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.employee_management_system
{
    internal class FullTimeEmployee : Employee, IDepartment
    {
        private string Department;
        //constructor
        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary)
        {
        }
        //abstract method override
        public override double CalculateSalary()
        {
            return GetBaseSalary();
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
