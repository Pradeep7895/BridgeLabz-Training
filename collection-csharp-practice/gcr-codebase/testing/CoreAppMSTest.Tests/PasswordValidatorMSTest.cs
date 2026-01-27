using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class PasswordValidatorMSTest
    {
        private PasswordValidator validator = null!;

        [TestInitialize]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [DataTestMethod]
        [DataRow("Password1", true)]   
        [DataRow("Pass1", false)]      
        [DataRow("password1", false)]  
        [DataRow("Password", false)] 
        [DataRow("", false)]           
        public void IsValid_VariousPasswords(string password, bool expected)
        {
            bool result = validator.IsValid(password);
            Assert.AreEqual(expected, result);
        }
    }

}



