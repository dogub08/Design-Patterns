using Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Concrete
{
    public class CustomerObserver : BaseObserver
    {
        public override void Notification() => Console.WriteLine("Message to Customer ==>  The price of the product has changed!");
    }
}
