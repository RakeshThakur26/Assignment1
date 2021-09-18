using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class ReUseOfCode
    {
        public void TicketBooking()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("This is Offline Ticket Booking...!");
        }

        public void FlightPanning()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Flight Panning Page..!");
        }

        public void Aircraft()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Aircraft maintainance Page...!");
        }
    }

    class E_Ticket : ReUseOfCode
    {
        public void ETicket()
        {
            Console.WriteLine(".............................");
            Console.WriteLine("Inheriting class ReUseOfCode");
            Console.WriteLine("******************************");
            Console.WriteLine("Online ticket booking page...!");
        }
    }
}
