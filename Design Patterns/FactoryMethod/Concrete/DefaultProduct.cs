using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom() => "Don't Avaible..!";
    }
}
