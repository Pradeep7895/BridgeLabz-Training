using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_manager
{
    internal class Program
    {
        static void Main()
        {
            CallManager manager = new CallManager(10);

            //add call logs
            manager.AddCallLog(new CallLog("7895914026", "Internet speed related problem", DateTime.Now.AddHours(-4)));
            manager.AddCallLog(new CallLog("7878435347", "Network speed related problem", DateTime.Now.AddHours(-2.5)));
            manager.AddCallLog(new CallLog("1234567890", "Network issue problem in mobile phone", DateTime.Now.AddHours(-2)));
            manager.AddCallLog(new CallLog("9876543210", "Too much spam messages issue", DateTime.Now.AddHours(-1.5)));
            manager.AddCallLog(new CallLog("7893455026", "Billing related problem", DateTime.Now.AddHours(-1)));

            //search by keyword 
            manager.SearchByKeyword("speed");

            DateTime start = DateTime.Now.AddHours(-2.5);
            DateTime end = DateTime.Now;

            //filter by time
            manager.FilterByTime(start, end);
        }
    }
}
