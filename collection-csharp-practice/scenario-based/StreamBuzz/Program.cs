using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.StreamBuzz
{
    internal class StreamBuzzMain
    {
        public static void Main(string[] args)
        {
            IEngagement utility = new EngagementUtility();
            Menu menu = new Menu(utility);
            menu.Start();
        }
    }
}