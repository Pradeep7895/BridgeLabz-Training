using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class Tab
    {
        public int TabId;
        private HistoryManager history;

        public Tab(int id)
        {
            TabId = id;
            history = new HistoryManager();
        }

        public void Navigate(string url)
        {
            history.VisitPage(url);
        }

        public void Back()
        {
            history.GoBack();
        }

        public void Forward()
        {
            history.GoForward();
        }

        public void ShowCurrentPage()
        {
            Console.WriteLine("Tab " + TabId + " -> " + history.GetCurrentPage());
        }

    }
}

  