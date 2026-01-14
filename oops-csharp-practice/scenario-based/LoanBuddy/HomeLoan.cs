using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class HomeLoan : LoanApplication , IApprovable
    {
        public HomeLoan(Applicant applicant, int term)
            : base(applicant, term, 9.8)
        {

        }

        public bool ApproveLoan()
        {
            Applicant applicant = GetApplicant();

            if(applicant.GetCreditScore() >= 700 && applicant.GetIncome() >= 50000)
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
