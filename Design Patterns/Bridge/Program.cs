using Bridge.Clients;
using Bridge.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Client(new Operation_A()).Operation());
            Console.WriteLine(new Client(new Operation_B()).Operation());
            Console.ReadKey();
        }
    }
}
