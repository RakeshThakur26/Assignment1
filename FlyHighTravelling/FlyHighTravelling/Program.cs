
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighTravelling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. First Class\n2. Business class\n3. Economy class\n");
            Console.WriteLine("Please Select the travelling class..!");
            CheckWeight cw = new CheckWeight();
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your luggage Weight..!");
            int w = Convert.ToInt32(Console.ReadLine());

            cw.Check(n,w);


        }
    }
}
