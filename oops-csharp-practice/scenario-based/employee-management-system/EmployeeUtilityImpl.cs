using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_management_system
{
    internal class EmployeeUtilityImpl : IEmployee

    {
        //object reference at class level
        private Employee employee;
        public Employee CheckAttendance()
        {
            //object creation
            employee = new Employee();
            Random random = new Random();
            bool attendence = random.Next(0, 2) ==1;

            employee.SetEmployeeId(1);
            employee.SetEmployeeName("Pradeep");
            employee.SetIsPresent(attendence);


            return employee;
        }
    }
}
