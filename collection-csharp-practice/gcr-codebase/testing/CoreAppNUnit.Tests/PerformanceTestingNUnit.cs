using NUnit.Framework;
using CoreApp;

namespace CoreAppNUnit.Tests
{

    [TestFixture]
    public class PerformanceTestingNUnit
    {
        private PerformanceTesting utils = null!;

        [SetUp]
        public void Setup()
        {
            utils = new PerformanceTesting();
        }

        // Test will FAIL if execution takes more than 2000 ms
        [Test]
        [Timeout(2000)]
        public void LongRunningTask_ShouldFinishWithinTwoSeconds()
        {
            utils.LongRunningTask();
        }
    }

}


