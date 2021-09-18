using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            viewMaintenance details = new viewMaintenance();
            Console.WriteLine("!. Offline Ticket Booking\n2. Online Ticket Booking\n3. View Maintenance Details\n");
            Console.WriteLine("Please Enter your option..");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                details.BookTickets();
            else if (n == 2)
                details.ETickets();
            else if (n == 3)
                details.Maintenance();
            else
                Environment.Exit(0);

            Console.Read();
        }
    }
}
