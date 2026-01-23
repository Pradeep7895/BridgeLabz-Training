using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.exceptions
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {

        }
    }

    class BankAccount
    {
        private double Balance;

        public BankAccount(double currentBalance)
        {
            Balance = currentBalance;
        }

        public void Withdraw(double amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Invalid Amount!");
            }
            if(Balance < amount)
            {
                throw new InsufficientExecutionStackException("Insufficient Balance");
            }
            Balance -= amount;
            Console.WriteLine("Withdraw Successful. New Balance :" + Balance);
        }
    }
    internal class BankTransactionSystem
    {
        static void Main()
        {
            BankAccount account = new BankAccount(10000);
            try
            {
                Console.WriteLine("Enter withdraw amount: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InsufficientExecutionStackException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid Number");
            }
        }
    }
}
