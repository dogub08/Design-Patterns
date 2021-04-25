using FactoryMethod.Concrete;
using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCreator productCreator = new ProductCreator();
            IProduct productShip;

            for (int i = 1; i <= 12; ++i)
            {
                productShip = productCreator.FactoryMethod(i);
                Console.WriteLine($"Coffee Beans Ship From: {productShip.ShipFrom()}");
                Console.ReadKey();
            }
        }
    }
}
