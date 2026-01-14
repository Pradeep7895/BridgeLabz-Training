using BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class LoanApplication
    {
        // All fields are private
        private Applicant Applicant;
        private int Term;
        private double InterestRate;
        private bool IsApproved;

        // Constructor
        public LoanApplication(Applicant applicant, int term, double interestRate)
        {
            Applicant = applicant;
            Term = term;
            InterestRate = interestRate;
        }

        //protected methods for child classes
        protected Applicant GetApplicant()
        {
            return Applicant;
        }

        protected int GetTerm()
        {
            return Term;
        }

        protected double GetInterestRate()
        {
            return InterestRate;
        }

        protected void SetApprovalStatus(bool status)
        {
            IsApproved = status;
        }

        // Common EMI calculation
        protected double CalculateEMIFormula()
        {
            double P = Applicant.GetLoanAmount();
            double R = InterestRate / (12 * 100); 
            int N = Term;

            return (P * R * Math.Pow(1 + R, N)) /
                   (Math.Pow(1 + R, N) - 1);
        }
    }
}

   