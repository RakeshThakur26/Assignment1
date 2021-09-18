using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            E_Ticket obj = new E_Ticket();

            // Offline Ticket Booking Page
            /* obj.TicketBooking();

             obj.FlightPanning();
             obj.Aircraft();

             // Online Ticket Booking Page with Inheriting the Base class ReUseOfCode
             obj.ETicket();
            */

            // Interfaces Concept

            InterfacesExample it = new InterfacesExample();
            it.print();

            Console.Read();
        }
    }
}
