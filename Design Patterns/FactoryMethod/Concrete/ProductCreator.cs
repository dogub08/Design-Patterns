using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class ProductCreator
    {
        public IProduct FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
                return new Product_A();
            else
            {
                if (month == 1 || month == 2 || month == 12)
                    return new Product_B();
                else
                    return new DefaultProduct();
            }
        }

    }
}
