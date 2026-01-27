using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;
using System;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class BankAccountMSTest
    {
        private BankAccount account = null!;

        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount(1000); // initial balance
        }

        [TestMethod]
        public void Deposit_ValidAmount()
        {
            account.Deposit(500);

            Assert.AreEqual(1500, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_ValidAmount()
        {
            account.Withdraw(300);

            Assert.AreEqual(700, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_InsufficientFunds()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                account.Withdraw(2000);
            });
        }

        [TestMethod]
        public void Deposit_InvalidAmount()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                account.Deposit(-100);
            });
        }
    }
}



    
