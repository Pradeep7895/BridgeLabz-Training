using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// bus reversion system 
// 20 tickets
// user gender,male female handicap
// reserved tickets for male, female and handicap
//and price per ticket

namespace BridgeLabzTraining.review
{
    internal class Tickets
    {
        // tickets
        static char[] tickets = new char[20];

        // price per ticket
        static int[] price = { 110 };

        // Book Tickets
        public void BookTicket()
        {
            Console.Write("Enter number of tickets to book: ");
            int count = int.Parse(Console.ReadLine());

            int totalPrice = 0;

            for (int j = 1; j <= count; j++)
            {
                Console.WriteLine($"\nTicket {j}");
                Console.WriteLine("Enter gender (M/F/H)");
                char gender = char.ToUpper(Console.ReadLine()[0]);

                int seatNo = -1;

                if (gender == 'H')
                    seatNo = Allocate(0, 2);
                else if (gender == 'F')
                    seatNo = Allocate(3, 10);
                else if (gender == 'M')
                    seatNo = Allocate(11, 20);
                else
                {
                    Console.WriteLine("Invalid Gender");
                    j--;
                    continue;
                }

                if (seatNo == -1)
                {
                    Console.WriteLine("No seat available .");
                    break;
                }
                else
                {
                    Console.WriteLine("Ticket Booked.");
                    Console.WriteLine($"Seat Number : {seatNo + 1}");
                    totalPrice += price[0];
                }
            }

            
            Console.WriteLine($"Total Tickets Booked Price : {totalPrice}");
            
        }

       
        public int Allocate(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (tickets[i] == 'E')
                {
                    tickets[i] = 'B';
                    return i;
                }
            }
            return -1;
        }

       
        public void ShowSeats()
        {
            Console.WriteLine("\nTickets Status:");
            for (int i = 0; i < tickets.Length; i++)
            {
                Console.WriteLine($"Seat {i + 1}: {(tickets[i] == 'E' ? "Empty" : "Booked")}");
            }
        }

        
        public void RemainingSeats()
        {
            int remaining = 0;

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == 'E')
                    remaining++;
            }

            Console.WriteLine("Remaining Seats: " + remaining);
        }

      
        static void Main()
        {
            Tickets ticket = new Tickets();

            for (int i = 0; i < tickets.Length; i++)
            {
                tickets[i] = 'E';
            }

            while (true)
            {
                Console.WriteLine("\n BUS RESERVATION SYSTEM : ");
                Console.WriteLine("Route From Mathura to Agra");
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Show Seat Status");
                Console.WriteLine("3. Remaining seats");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ticket.BookTicket();
                        break;
                    case 2:
                        ticket.ShowSeats();
                        break;
                    case 3:
                        ticket.RemainingSeats();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
