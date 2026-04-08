using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class DatabaseConnectionMSTest
    {
        private DatabaseConnection db = null!;

        // Runs BEFORE each test
        [TestInitialize]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        // Runs AFTER each test
        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [TestMethod]
        public void Connect_IsCalled()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void Disconnect_IsCalled()
        {
            // Act
            db.Disconnect();

            // Assert
            Assert.IsFalse(db.IsConnected);
        }

    }
}



        