using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;
using System.Collections.Generic;

namespace CoreAppMSTest.Tests
{
    [TestClass]
    public class ListManagerMSTest
    {
        private ListManager manager = null!;
        private List<int> list = null!;

        // Runs before each test
        [TestInitialize]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int>();
        }

        [TestMethod]
        public void AddElement()
        {
            manager.AddElement(list, 10);

            CollectionAssert.Contains(list, 10);
        }

        [TestMethod]
        public void RemoveElement()
        {
            list.Add(10);
            list.Add(20);

            manager.RemoveElement(list, 10);

            CollectionAssert.DoesNotContain(list, 10);
        }

        [TestMethod]
        public void GetSize()
        {
            manager.AddElement(list, 10);
            manager.AddElement(list, 20);

            int size = manager.GetSize(list);

            Assert.AreEqual(2, size);
        }
    }

}



