using System;
using CoreApp;
using NUnit.Framework;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class ExceptionHandlingNUnit
    { 
        private ExceptionHandling handling = null!;

        [SetUp]
        public void Setup()
        {
            handling = new ExceptionHandling();
        }

        [Test]
        public void Divide_ByZero()
        {
            // Assert that exception is thrown
            Assert.Throws<ArithmeticException>(() =>
            {
                handling.Divide(10, 0);
            });
        }
    }
}
