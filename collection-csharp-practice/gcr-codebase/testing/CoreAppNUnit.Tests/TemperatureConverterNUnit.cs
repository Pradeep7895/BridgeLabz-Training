using NUnit.Framework;
using CoreApp;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class TemperatureConverterNUnit
    {
        private TemperatureConverter converter = null!;

        [SetUp]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(-40, -40)]
        public void CelsiusToFahrenheit(double celsius, double expectedFahrenheit)
        {
            double result = converter.CelsiusToFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, result);
        }

        [TestCase(32, 0)]
        [TestCase(212, 100)]
        [TestCase(-40, -40)]
        public void FahrenheitToCelsius(double fahrenheit, double expectedCelsius)
        {
            double result = converter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, result);
        }
    }

}


