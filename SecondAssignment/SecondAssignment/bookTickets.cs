using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
   abstract class bookTickets
    {
        public void BookTickets()
        {
            Console.WriteLine("Welcome to Offline Ticket Booking ....!\n");
        }

       public abstract void ETickets();


    }

    abstract class BookETickets : bookTickets
    {
        public override void ETickets()
        {
            Console.WriteLine("Hello, Welcome to Online Ticket Booking...!\n");
        }
        public abstract void Maintenance();

    }

    class viewMaintenance : BookETickets
    {
        public override void Maintenance()
        {
            Console.WriteLine("Maintainance details of Airlines...!\n");
        }

    }

}
