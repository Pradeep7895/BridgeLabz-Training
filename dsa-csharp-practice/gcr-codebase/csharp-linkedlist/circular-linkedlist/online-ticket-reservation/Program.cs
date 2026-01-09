using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.online_ticket_reservation
{
    internal class Program
    {
        static void Main()
        {
            // Create ticket system
            TicketCircularList tickets = new TicketCircularList();

            // Add tickets
            tickets.AddTicket(1, "Amit", "Avatar", 15, "10:00 AM");
            tickets.AddTicket(2, "Neha", "Avatar", 16, "10:05 AM");
            tickets.AddTicket(3, "Rahul", "Inception", 20, "10:10 AM");

            // Display tickets
            Console.WriteLine("All Tickets:");
            tickets.DisplayTickets();

            // Search by customer
            Console.WriteLine("\nSearch by Customer:");
            tickets.SearchByCustomer("Amit");

            // Search by movie
            Console.WriteLine("\nSearch by Movie:");
            tickets.SearchByMovie("Avatar");

            // Remove ticket
            Console.WriteLine("\nRemove Ticket :");
            tickets.RemoveTicket(2);

            // Display again
            Console.WriteLine("\nAfter Removal:");
            tickets.DisplayTickets();

            // Count tickets
            tickets.CountTickets();
        }

    }
}

    