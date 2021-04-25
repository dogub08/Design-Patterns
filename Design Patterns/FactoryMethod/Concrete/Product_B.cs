using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class Product_B : IProduct
    {
        public string ShipFrom() => "From Colombia..!";
    }
}
