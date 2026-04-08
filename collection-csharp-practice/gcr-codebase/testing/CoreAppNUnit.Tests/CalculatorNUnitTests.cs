using NUnit.Framework;
using CoreApp;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        private Calculator calculator = null!;

        // Runs before EACH test
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ReturnsSum()
        {
            int result = calculator.Add(5, 5);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Subtract_ReturnsDifference()
        {
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_ReturnsProduct()
        {
            int result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_ReturnsQuotient()
        {
            int result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                calculator.Divide(10, 0);
            });
        }
    }
}
