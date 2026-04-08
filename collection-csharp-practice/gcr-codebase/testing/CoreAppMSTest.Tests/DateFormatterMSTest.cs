using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;
using System;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class DateFormatterMSTest
    {
        private DateFormatter formatter = null!;

        [TestInitialize]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [DataTestMethod]
        [DataRow("2024-01-15", "15-01-2024")]
        [DataRow("1999-12-31", "31-12-1999")]
        public void FormatDate_ValidDate(string input, string expected)
        {
            string result = formatter.FormatDate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("15-01-2024")]
        [DataRow("2024/01/15")]
        [DataRow("invalid-date")]
        [DataRow("")]
        public void FormatDate_InvalidDate(string input)
        {
            Assert.ThrowsException<FormatException>(() =>
            {
                formatter.FormatDate(input);
            });
        }
    }

}


