using NUnit.Framework;
using CoreApp;
using System;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class DateFormatterNUnit
    {
        private DateFormatter formatter = null!;

        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [TestCase("2024-01-15", "15-01-2024")]
        [TestCase("1999-12-31", "31-12-1999")]
        public void FormatDate_ValidDate(string input, string expected)
        {
            string result = formatter.FormatDate(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase("15-01-2024")]
        [TestCase("2024/01/15")]
        [TestCase("invalid-date")]
        [TestCase("")]
        public void FormatDate_InvalidDate(string input)
        {
            Assert.Throws<FormatException>(() =>
            {
                formatter.FormatDate(input);
            });
        }
    }

}



