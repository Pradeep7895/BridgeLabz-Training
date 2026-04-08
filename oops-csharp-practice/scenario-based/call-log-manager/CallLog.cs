using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_manager
{
    internal class CallLog
    {
        private string phoneNumber;
        private string message;
        private DateTime timestamp;

        //constructor
        public CallLog(string phoneNumber, string message, DateTime timestamp)
        {
            this.phoneNumber = phoneNumber;
            this.message = message;
            this.timestamp = timestamp;

        }
        //getter and setter
        //for phone  number
        public string GetPhoneNumber() { return phoneNumber; }
        public void SetPhoneNumber(string phoneNumber) { this.phoneNumber = phoneNumber; }

        //for message
        public string GetMessage() { return message; }
        public void SetMessage(string message) {  this.message = message; }
        
        //for timestamp
        public DateTime GetTimestamp() { return timestamp; }
        public void SetTimestamp(DateTime timestamp) { this.timestamp = timestamp; }

        //ToString method override
        public override string ToString()
        {
            return $"Phone Number : {phoneNumber}\n" +
                $"Message : {message}\n" +
                $"Time : {timestamp}";
        }
    }
}
