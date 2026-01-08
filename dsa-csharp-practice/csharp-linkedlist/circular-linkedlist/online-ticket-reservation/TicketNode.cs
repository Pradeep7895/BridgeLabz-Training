using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.csharp_linkedlist.circular_linkedlist.online_ticket_reservation
{
    internal class TicketNode
    {
        // Ticket details
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public int SeatNumber;
        public string BookingTime;

        // Pointer to next ticket 
        public TicketNode Next;

        // Constructor to assign values
        public TicketNode(int id, string customer, string movie, int seat, string time)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            Next = null;
        }

    }
}

   