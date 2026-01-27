using NUnit.Framework;
using CoreApp;
using System.Collections.Generic;

namespace CoreAppNUnit.Tests
{
    [TestFixture]
    public class ListManagerNUnit
    {
        private ListManager manager = null;
        private List<int> list = null;

        //runs before each test
        [SetUp]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }

        [Test]
        public void AddElement()
        {
            manager.AddElement(list, 10);
            Assert.Contains(10, list);
        }

        [Test]
        public void RemoveElement()
        {
            list.Add(10);
            list.Add(20);

            manager.RemoveElement(list, 10);

            Assert.IsFalse(list.Contains(10));
        }

        [Test]
        public void GetSize()
        {
            manager.AddElement(list, 10);
            manager.AddElement(list, 20);

            int size = manager.GetSize(list);

            Assert.AreEqual(2, size);
        }
    }
}
