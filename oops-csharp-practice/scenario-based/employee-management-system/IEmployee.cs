using BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_management_system
{
    internal interface IEmployee
    {
        Employee CheckAttendance();
        Employee CalculateDailyWage();
        Employee CalculatePartTimeWage();

        int GetPresentDays();
        Employee CalculateMonthlyWage();
        Employee CalculateWageWithCondition();
    }
}
