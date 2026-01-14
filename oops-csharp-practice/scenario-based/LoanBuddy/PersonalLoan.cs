using BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class PersonalLoan : LoanApplication, IApprovable
    {
        public PersonalLoan(Applicant applicant, int term)
       : base(applicant, term, 14.0) { }

        public bool ApproveLoan()
        {
            Applicant applicant = GetApplicant();

            if (applicant.GetCreditScore() >= 600 &&
                applicant.GetIncome() >= 25000)
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

   