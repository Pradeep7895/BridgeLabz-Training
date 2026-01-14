using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class Applicant
    {
        //instance vriables
        private string Name;
        private int CreditScore;
        private double Income;
        private double LoanAmount;

        //constructor
        public Applicant(string Name, int CreditScore, double Income, double LoanAmount)
        {
            this.Name = Name;
            this.CreditScore = CreditScore;
            this.Income = Income;
            this.LoanAmount = LoanAmount;
        }
        //public getter methods
        public string GetName() { return Name; }

        public int GetCreditScore() { return CreditScore; } 
        
        public double GetIncome() { return Income; }

        public double GetLoanAmount() { return LoanAmount; }
    }
}
