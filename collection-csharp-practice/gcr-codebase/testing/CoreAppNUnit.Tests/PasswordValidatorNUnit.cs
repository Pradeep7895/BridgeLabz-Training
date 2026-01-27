using NUnit.Framework;
using CoreApp;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class PasswordValidatorNUnit
    {
        private PasswordValidator validator = null!;

        [SetUp]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [TestCase("Password1", true)]   
        [TestCase("Pass1", false)]       
        [TestCase("password1", false)]   
        [TestCase("Password", false)]    
        [TestCase("", false)]            
        public void IsValid_VariousPasswords(string password, bool expected)
        {
            bool result = validator.IsValid(password);
            Assert.AreEqual(expected, result);
        }
    }

}



