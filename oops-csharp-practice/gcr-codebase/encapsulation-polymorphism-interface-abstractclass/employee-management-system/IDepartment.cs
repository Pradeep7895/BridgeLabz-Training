using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.employee_management_system
{
    internal interface IDepartment
    {
        //method for assign department
        void AssignDepartment(string departmentName);
        //method for display department details
        string GetDepartmentDetails();
    }
}
