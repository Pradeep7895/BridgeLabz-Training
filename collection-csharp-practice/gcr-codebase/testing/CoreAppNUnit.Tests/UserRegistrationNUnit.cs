using NUnit.Framework;
using CoreApp;
using System;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class UserRegistrationNUnit
    {
        private UserRegistration registration = null!;

        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInputs()
        {
            bool result = registration.RegisterUser(
                "john_doe",
                "john@example.com",
                "password123");

            Assert.IsTrue(result);
        }

        [TestCase("", "john@example.com", "password123")]
        [TestCase("john", "invalid-email", "password123")]
        [TestCase("john", "john@example.com", "123")]
        public void RegisterUser_InvalidInputs(
            string username, string email, string password)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                registration.RegisterUser(username, email, password);
            });
        }
    }

}



