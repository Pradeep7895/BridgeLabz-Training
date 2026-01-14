using BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class AutoLoan : LoanApplication, IApprovable
    {
        public AutoLoan(Applicant applicant, int term)
       : base(applicant, term, 10.5) { }

        public bool ApproveLoan()
        {
            Applicant applicant = GetApplicant();

            if (applicant.GetCreditScore() >= 650 &&
                applicant.GetIncome() >= 30000)
            {
                SetApprovalStatus(true);
                return true;
            }

            SetApprovalStatus(false);
            return false;
        }

        public double CalculateEMI()
        {
            return CalculateEMIFormula();
        }

    }
}

   