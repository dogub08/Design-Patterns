using Adapter.Concrete;
using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter_A adapter = new Adapter_A();
            Console.WriteLine($"Result without Adapter  => Estimated Result: {adapter.SpesificRequest(5, 3)}");

            ITarget adapter_2 = new Client();
            Console.WriteLine($"Result with Adapter => {adapter_2.Request(5)}");
        }
    }
}
