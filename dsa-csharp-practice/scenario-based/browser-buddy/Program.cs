using BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            int choice;

            do
            {
                Console.WriteLine("\nBrowserBuddy Menu : ");
                Console.WriteLine("1. Open New Tab");
                Console.WriteLine("2. Visit Page");
                Console.WriteLine("3. Back");
                Console.WriteLine("4. Forward");
                Console.WriteLine("5. Show Current Page");
                Console.WriteLine("6. Close Current Tab");
                Console.WriteLine("7. Reopen Closed Tab");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        browser.OpenTab();
                        break;

                    case 2:
                        if (browser.GetActiveTab() == null)
                        {
                            Console.WriteLine("No active tab.");
                            break;
                        }
                        Console.Write("Enter URL: ");
                        string url = Console.ReadLine();
                        browser.GetActiveTab().Navigate(url);
                        break;

                    case 3:
                        browser.GetActiveTab()?.Back();
                        break;

                    case 4:
                        browser.GetActiveTab()?.Forward();
                        break;

                    case 5:
                        browser.GetActiveTab()?.ShowCurrentPage();
                        break;

                    case 6:
                        browser.CloseCurrentTab();
                        break;

                    case 7:
                        browser.ReopenClosedTab();
                        break;

                    case 0:
                        Console.WriteLine("Exiting BrowserBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }


    }
}


