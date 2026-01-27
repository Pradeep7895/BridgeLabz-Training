using CoreApp;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class StringUtilityMethodsNUnit
    {
        private StringUtilityMethods utils = null!;

        // Runs before each test
        [SetUp]
        public void Setup()
        {
            utils = new StringUtilityMethods();
        }

        [Test]
        public void Reverse_Valid()
        {
            string result = utils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void IsPalindrome_ReturnsTrue()
        {
            bool result = utils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ReturnsFalse()
        {
            bool result = utils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void ToUpperCase()
        {
            string result = utils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }

        [Test]
        public void Reverse_Null()
        {
            string result = utils.Reverse(null);
            Assert.IsNull(result);
        }
    }

}




