using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.CustomerQueueMenagement
{
    internal interface IUtility
    {
        void AddCustomer(Customer customer);
        void ProcessNextCustomer();
    }
}
