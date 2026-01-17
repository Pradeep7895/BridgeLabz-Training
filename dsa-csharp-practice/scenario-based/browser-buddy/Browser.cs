using BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class Browser
    {
        private Tab[] tabs = new Tab[10];
        private int tabCount = 0;
        private ClosedTabStack closedTabs = new ClosedTabStack();
        private Tab activeTab;

        public void OpenTab()
        {
            Tab tab = new Tab(tabCount + 1);
            tabs[tabCount++] = tab;
            activeTab = tab;
            Console.WriteLine("Opened Tab " + tab.TabId);
        }

        public void CloseCurrentTab()
        {
            if (activeTab == null)
            {
                Console.WriteLine("No active tab.");
                return;
            }

            closedTabs.Push(activeTab);
            Console.WriteLine("Closed Tab " + activeTab.TabId);
            activeTab = null;
        }

        public void ReopenClosedTab()
        {
            Tab tab = closedTabs.Pop();
            if (tab != null)
            {
                tabs[tabCount++] = tab;
                activeTab = tab;
                Console.WriteLine("Reopened Tab " + tab.TabId);
            }
            else
            {
                Console.WriteLine("No closed tabs to reopen.");
            }
        }

        public Tab GetActiveTab()
        {
            return activeTab;
        }


    }
}


    