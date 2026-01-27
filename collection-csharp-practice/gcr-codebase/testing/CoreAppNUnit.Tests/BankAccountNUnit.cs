using NUnit.Framework;
using CoreApp;
using System;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class BankAccountNUnit
    {
        private BankAccount account = null!;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(1000); // initial balance
        }

        [Test]
        public void Deposit_ValidAmount()
        {
            account.Deposit(500);

            Assert.AreEqual(1500, account.GetBalance());
        }

        [Test]
        public void Withdraw_ValidAmount()
        {
            account.Withdraw(300);

            Assert.AreEqual(700, account.GetBalance());
        }

        [Test]
        public void Withdraw_InsufficientFunds()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                account.Withdraw(2000);
            });
        }

        [Test]
        public void Deposit_InvalidAmount()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                account.Deposit(-100);
            });
        }
    }

}


