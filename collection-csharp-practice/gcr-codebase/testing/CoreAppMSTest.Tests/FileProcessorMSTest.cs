using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;
using System.IO;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class FileProcessorMSTest
    {
        private FileProcessor processor = null!;
        private string testFilePath = null!;

        // Runs before each test
        [TestInitialize]
        public void Setup()
        {
            processor = new FileProcessor();
            testFilePath = Path.GetTempFileName();
        }

        // Runs after each test
        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [TestMethod]
        public void WriteAndRead()
        {
            string content = "Hello MSTest";

            processor.WriteToFile(testFilePath, content);
            string result = processor.ReadFromFile(testFilePath);

            Assert.AreEqual(content, result);
        }

        [TestMethod]
        public void WriteToFile()
        {
            processor.WriteToFile(testFilePath, "Test Data");

            Assert.IsTrue(File.Exists(testFilePath));
        }

        [TestMethod]
        public void ReadFromFile()
        {
            File.Delete(testFilePath);

            Assert.ThrowsException<IOException>(() =>
            {
                processor.ReadFromFile(testFilePath);
            });
        }
    }
}



    