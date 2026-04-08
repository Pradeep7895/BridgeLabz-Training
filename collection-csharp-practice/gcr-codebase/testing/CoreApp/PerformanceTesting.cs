

using System.Threading;

namespace CoreApp
{
    public class PerformanceTesting
    {
        public int LongRunningTask()
        {
            // Simulate long task (3 seconds)
            Thread.Sleep(3000);
            return 1;
        }
    }
}
