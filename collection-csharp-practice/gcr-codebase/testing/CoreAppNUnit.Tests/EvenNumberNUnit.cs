using NUnit.Framework;
using CoreApp;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class EvenNumberNUnit
    {
        private EvenNumber even = null!;

        [SetUp]
        public void Setup()
        {
            even = new EvenNumber();
        }

        // Parameterized test using TestCase
        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_MultipleValues_ReturnsExpectedResult(int number, bool expected)
        {
            bool result = even.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }
}
