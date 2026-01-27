using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class TemperatureConverterMSTest
    {
        private TemperatureConverter converter = null!;

        [TestInitialize]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [DataTestMethod]
        [DataRow(0, 32)]
        [DataRow(100, 212)]
        [DataRow(-40, -40)]
        public void CelsiusToFahrenheit(double celsius, double expectedFahrenheit)
        {
            double result = converter.CelsiusToFahrenheit(celsius);
            Assert.AreEqual(expectedFahrenheit, result);
        }

        [DataTestMethod]
        [DataRow(32, 0)]
        [DataRow(212, 100)]
        [DataRow(-40, -40)]
        public void FahrenheitToCelsius(double fahrenheit, double expectedCelsius)
        {
            double result = converter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, result);
        }
    }

}


