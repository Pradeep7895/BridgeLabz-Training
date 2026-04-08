using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.online_ticket_reservation
{
    internal class TicketCircularList
    {
        // Head points to first ticket
        private TicketNode head;

        // Tail points to last ticket
        private TicketNode tail;

        // 1️. Add new ticket at end
        public void AddTicket(int id, string customer, string movie, int seat, string time)
        {
            // Create new ticket
            TicketNode newNode = new TicketNode(id, customer, movie, seat, time);

            // If list is empty
            if (head == null)
            {
                head = tail = newNode;
                // make circular
                tail.Next = head;   
                return;
            }

            // Add ticket after tail
            tail.Next = newNode;
            newNode.Next = head;
            tail = newNode;
        }

        // 2️. Remove ticket using Ticket ID
        public void RemoveTicket(int id)
        {
            // If list is empty
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            // If only one ticket and it matches
            if (head == tail && head.TicketId == id)
            {
                head = tail = null;
                Console.WriteLine("Ticket removed");
                return;
            }

            // If first ticket is removed
            if (head.TicketId == id)
            {
                head = head.Next;
                tail.Next = head;
                Console.WriteLine("Ticket removed");
                return;
            }

            // Temporary pointer
            TicketNode temp = head;

            // Search ticket
            while (temp.Next != head && temp.Next.TicketId != id)
            {
                temp = temp.Next;
            }

            // If ticket not found
            if (temp.Next == head)
            {
                Console.WriteLine("Ticket not found");
                return;
            }

            // If last ticket is removed
            if (temp.Next == tail)
                tail = temp;

            // Remove ticket
            temp.Next = temp.Next.Next;
            Console.WriteLine("Ticket removed");
        }

        // 3️. Display all tickets
        public void DisplayTickets()
        {
            // If no tickets
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode temp = head;

            // Traverse circular list
            do
            {
                PrintTicket(temp);
                temp = temp.Next;
            }
            while (temp != head);
        }

        // 4️. Search ticket by Customer Name
        public void SearchByCustomer(string name)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            // Traverse list
            do
            {
                if (temp.CustomerName == name)
                {
                    PrintTicket(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            while (temp != head);

            if (!found)
                Console.WriteLine("Ticket not found");
        }

        // 5️. Search ticket by Movie Name
        public void SearchByMovie(string movie)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            bool found = false;

            // Traverse list
            do
            {
                if (temp.MovieName == movie)
                {
                    PrintTicket(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            while (temp != head);

            if (!found)
                Console.WriteLine("Ticket not found");
        }

        // 6️. Count total tickets
        public void CountTickets()
        {
            // If no tickets
            if (head == null)
            {
                Console.WriteLine("Total Tickets: 0");
                return;
            }

            int count = 0;
            TicketNode temp = head;

            // Count nodes
            do
            {
                count++;
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine("Total Tickets: " + count);
        }

        // Print one ticket
        private void PrintTicket(TicketNode t)
        {
            Console.WriteLine(
                "Ticket ID: " + t.TicketId +
                ", Customer: " + t.CustomerName +
                ", Movie: " + t.MovieName +
                ", Seat: " + t.SeatNumber +
                ", Time: " + t.BookingTime
            );
        }

    }
}
    