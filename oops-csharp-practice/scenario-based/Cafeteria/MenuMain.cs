using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.Cafeteria
{
    internal class MenuMain
    {
        static void Main(string[] args)
        {
            //object of CafeteriaMenu class
            CafeteriaMenu menu = new CafeteriaMenu();
            //variable to store total bill amount
            double totalBill = 0;
            int choice;

            Console.WriteLine("Welcome to Campus Cafeteria: ");

            do
            {
                //display options to user
                Console.WriteLine("\n1. Display Menu");
                Console.WriteLine("2. Order Item");
                Console.WriteLine("3. Exit & Generate Bill");
                Console.Write("Enter your choice: ");
                //read user choice and validate
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine(" Invalid input.");
                    continue;
                }
                //perform action based on user choice
                switch (choice)
                {
                    case 1:
                        menu.Display();
                        break;

                    case 2:
                        char moreOrder;

                        do
                        {
                            //display menu and prompt user to order item
                            menu.Display();
                            Console.Write("\nEnter item index to order: ");
                            int index;
                            //read item index and validate
                            if (int.TryParse(Console.ReadLine(), out index))
                                
                            {
                                //add item value to total bill
                                totalBill += menu.GetItemValue(index);
                                Console.WriteLine($"Added: {menu.GetItemByIndex(index)} - ₹{menu.GetItemValue(index)}");
                            }
                            else
                            {
                                Console.WriteLine(" Invalid item index.");
                            }
                            //ask user if they want to order more items
                            Console.Write("\nDo you want to order more items? (Y/N): ");
                            moreOrder = char.ToUpper(Console.ReadLine()[0]);

                        } while (moreOrder == 'Y');

                        break;

                    //case 3
                    //exit and generate bill
                    case 3:
                        Console.WriteLine("\nBILL SUMMARY ====>");
                        Console.WriteLine("Total Amount: " + totalBill);
                        Console.WriteLine("Thank you! Visit again ");
                        break;

                    default:
                        Console.WriteLine(" Choose between 1 and 3.");
                        break;
                }

            } while (choice != 3);
        }

    }
}
