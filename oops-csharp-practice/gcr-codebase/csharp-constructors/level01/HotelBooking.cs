using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level01
{
    internal class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int nights;

        //default constructor
        public HotelBooking()
        {
            guestName = "Pradeep";
            roomType = "Standard";
            nights = 1;
        }

        //para. constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        //copy constructor
        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }
        //method to display bookking details
        public void Display()
        {
            Console.WriteLine("\nBooking Details: ");
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Nights : " + nights);
        }

        public static void Main(string[] args)
        {
            //using default
            HotelBooking booking1 = new HotelBooking();
            booking1.Display();

            //using parameterized
            HotelBooking booking2 = new HotelBooking("Rahul", "Deluxe", 2);
            booking2.Display();

            //using copy
            HotelBooking booking3 = new HotelBooking(booking2);
            booking3.Display();
        }
    }
}
