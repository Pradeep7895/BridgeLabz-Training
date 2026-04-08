using NUnit.Framework;
using CoreApp;
using System.IO;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class FileProcessorNUnit
    {
        private FileProcessor processor = null!;
        private string testFilePath = null!;

        // Runs before each test
        [SetUp]
        public void Setup()
        {
            processor = new FileProcessor();
            testFilePath = Path.GetTempFileName();
        }

        // Runs after each test
        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [Test]
        public void WriteAndRead()
        {
            // Arrange
            string content = "Hello NUnit";

            // Act
            processor.WriteToFile(testFilePath, content);
            string result = processor.ReadFromFile(testFilePath);

            // Assert
            Assert.AreEqual(content, result);
        }

        [Test]
        public void WriteToFile()
        {
            processor.WriteToFile(testFilePath, "Test Data");

            Assert.IsTrue(File.Exists(testFilePath));
        }

        [Test]
        public void ReadFromFile_FileDoesNotExist()
        {
            File.Delete(testFilePath);

            Assert.Throws<IOException>(() =>
            {
                processor.ReadFromFile(testFilePath);
            });
        }
    }

}


