using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighTravelling
{
    class CheckWeight
    {
        public int FirstW = 50;
        public int BusinessW = 40;
        public int EconomyW = 20;

        public void Check(int n, int w)
        {
            if (n == 1)
            {
                if (w <= FirstW)
                    Console.WriteLine("Happy Journey..! :)");
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit.");
                    Console.WriteLine("You need to Pay " + (2 * (w - FirstW)) + "$ more.");
                }
            }
            else if (n == 2)
            {
                if (w <= BusinessW)
                    Console.WriteLine("Happy Journey..! :)");
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit.");
                    Console.WriteLine("You need to Pay " + (2 * (w - BusinessW)) + "$ more.");
                }
            }
            else if (n == 3)
            {
                if (w <= EconomyW)
                    Console.WriteLine("Happy Journey..! :)");
                else
                {
                    Console.WriteLine("Your Luggage weight exceeds maximum limit.");
                    Console.WriteLine("You need to Pay " + (2 * (w - EconomyW)) + "$ more.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice..");
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
