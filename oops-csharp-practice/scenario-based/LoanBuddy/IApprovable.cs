using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal interface IApprovable
    {
        double CalculateEMI();

        bool ApproveLoan();
    }
}
