//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.extras.level01
//{
//    internal class TimeZones
//    {
//        //method to convert UTC time to different time zones
//        static void Display(string timeZoneId, string zoneName, DateTimeOffset utcTime)
//        {
//            //get time zone info
//            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

//            //convert UTC time to specified time zone
//            DateTimeOffset zoneTime = TimeZoneInfo.ConvertTime(utcTime, tz);

//            //display the time
//            Console.WriteLine(zoneName + " Time: " + zoneTime);
//        }
//        static void Main()
//        {
//            //get current time in UTC
//            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

//            Console.WriteLine("Current time in different time zones:");

//            //display gmt time
//            Display("GMT Standard time", "GMT", utcTime);

//            //display ist time
//            Display("India Standard Time", "IST", utcTime);

//            //display pst time
//            Display("Pacific Standard Time", "PST", utcTime);
//        }
//    }
//}
