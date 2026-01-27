using NUnit.Framework;
using CoreApp;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class DatabaseConnectionNUnit
    {
        private DatabaseConnection db = null!;

        // Runs BEFORE each test
        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        // Runs AFTER each test
        [TearDown]
        public void TearDown()
        {
            db.Disconnect();
        }

        [Test]
        public void Connect_IsCalled()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [Test]
        public void Disconnect_IsCalled()
        {
            // Act
            db.Disconnect();

            // Assert
            Assert.IsFalse(db.IsConnected);
        }

    }
}

