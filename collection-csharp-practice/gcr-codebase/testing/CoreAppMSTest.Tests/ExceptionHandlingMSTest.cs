using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;
using System;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class ExceptionHandlingMSTest
    {
        private ExceptionHandling handling = null!;

        [TestInitialize]
        public void Setup()
        {
            handling = new ExceptionHandling();
        }

        [TestMethod]
        public void Divide_ByZero()
        {
            // Assert that exception is thrown
            Assert.ThrowsException<ArithmeticException>(() =>
            {
                handling.Divide(10, 0);
            });
        }
    }
}
