using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;


namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class CalculatorNUnitTests
    {
        private Calculator calculator = null!;

        // Runs before Each test
        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ReturnsSum()
        {
            int result = calculator.Add(5, 5);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Subtract_ReturnsDifference()
        {
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Multiply_ReturnsProduct()
        {
            int result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_ReturnsQuotient()
        {
            int result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        //Division by zero
        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                calculator.Divide(10, 0);
            });
        }
    }

}


    