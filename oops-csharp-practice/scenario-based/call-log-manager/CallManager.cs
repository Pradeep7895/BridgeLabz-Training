using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_manager
{
    internal class CallManager
    {
        private CallLog[] logs;
        private int count;

        //constructor
        public CallManager(int size)
        {
            logs = new CallLog[size];
            count = 0;
        }

        //method to search by keywords
        public void SearchByKeyword(string keyword)
        {
            Console.WriteLine($"\nLogs containing keyword : {keyword}");
            for (int i = 0; i < count; i++)
            {
                if (logs[i].GetMessage().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(logs[i]);
                    Console.WriteLine();
                }               
            }
        }
        //method for add call log by passing calllog object
        //by passing the params. one by one
        public void AddCallLog(CallLog log)
        {
            if(count <  logs.Length)
            {
                logs[count++] = log;
            }
            else
            {
                Console.WriteLine("Call log is full.");
            }
        }
        //method for filter by time
        public void FilterByTime(DateTime start, DateTime end)
        {
            Console.WriteLine($"\nLogs between {start} and {end} : ");
            for(int i = 0; i < count; i++)
            {
                if (logs[i].GetTimestamp() >= start && logs[i].GetTimestamp() <= end)
                {
                    Console.WriteLine(logs[i]);
                    Console.WriteLine();
                }
            }
        }

    }
}
