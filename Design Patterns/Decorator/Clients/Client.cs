using Decorator.Interface;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clients
{
    public class Client
    {
        public static void Display(string s, IComponent component) => Console.WriteLine(s + component.Operation());
    }
}

