using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class StringUtilityMethodsMSTest
    {
        private StringUtilityMethods utils = null!;

        // Runs before each test
        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtilityMethods();
        }

        [TestMethod]
        public void Reverse_Valid()
        {
            string result = utils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [TestMethod]
        public void IsPalindrome_ReturnsTrue()
        {
            bool result = utils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_ReturnsFalse()
        {
            bool result = utils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ToUpperCase()
        {
            string result = utils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }

        [TestMethod]
        public void Reverse_Null()
        {
            string result = utils.Reverse(null);
            Assert.IsNull(result);
        }
    }

}



