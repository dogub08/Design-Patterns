using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Concrete
{
    public class Client : Adapter_A, ITarget
    {
        public string Request(int number) => $"Estimated Result: {Math.Round(SpesificRequest(number, 3))}";
    }
}
