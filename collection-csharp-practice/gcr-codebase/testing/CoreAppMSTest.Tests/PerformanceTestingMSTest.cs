using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreApp;

namespace CoreAppMSTest.Tests
{

    [TestClass]
    public class PerformanceTestingMSTest
    {
        private PerformanceTesting utils = null!;

        [TestInitialize]
        public void Setup()
        {
            utils = new PerformanceTesting();
        }

        // Test will FAIL if execution takes more than 2000 ms
        [TestMethod]
        [Timeout(2000)]
        public void LongRunningTask_TwoSeconds()
        {
            utils.LongRunningTask();
        }
    }
}



