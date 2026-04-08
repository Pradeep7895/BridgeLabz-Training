using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class EvenNumberMSTest
    {
        private EvenNumber even = null!;

        [TestInitialize]
        public void Setup()
        {
            even = new EvenNumber();
        }

        // Parameterized test using DataRow
        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void IsEven_MultipleValues_ReturnsExpectedResult(int number, bool expected)
        {
            bool result = even.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }

}



