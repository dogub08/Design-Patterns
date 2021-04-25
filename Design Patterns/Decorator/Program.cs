using Decorator.Clients;
using Decorator.Concrete;
using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new BaseComponent();

            Client.Display("The Raw State of the Object ==> ", component);
            Console.WriteLine("\n");
            Client.Display("Object's Raw State was decorated with Decorator_A==> ", new Decorator_A(component));
            Console.WriteLine("\n");
            Client.Display("Corresponding object decorated with Decorator_B ==> ", new Decorator_B(component));
        }
    }
}
