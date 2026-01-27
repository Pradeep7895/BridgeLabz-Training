using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;
using System;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class UserRegistrationMSTest
    {
        private UserRegistration registration = null!;

        [TestInitialize]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [TestMethod]
        public void RegisterUser_ValidInputs()
        {
            bool result = registration.RegisterUser(
                "john_doe",
                "john@example.com",
                "password123");

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("", "john@example.com", "password123")]
        [DataRow("john", "invalid-email", "password123")]
        [DataRow("john", "john@example.com", "123")]
        public void RegisterUser_InvalidInputs(
            string username, string email, string password)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                registration.RegisterUser(username, email, password);
            });
        }
    }

}

