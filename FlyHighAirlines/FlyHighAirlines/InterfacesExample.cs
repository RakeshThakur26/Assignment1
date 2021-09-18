using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHighAirlines
{
    interface A
    {
        void print();
    }

    interface B
    {
        void print();
    }
    class InterfacesExample : A,B
    {
       public void print()
        {
            Console.WriteLine("Example for Interfaces...!");
        }
    }
}
