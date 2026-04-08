using System;

namespace BankAccount
{
    public class NotValidAmountException: Exception
    {
        public decimal Amount{get;}

        public NotValidAmountException(string message, decimal amount):base(message)
        {
            Amount = amount;
        } 
    }

    public class InSufficentFunds : Exception
    {
        public decimal Amount {get;}

        public InSufficentFunds(string message, decimal amount) : base(message)
        {
            Amount = amount;
        }
    }
}