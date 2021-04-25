using Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Concrete
{
    public class EmployeeObserver : BaseObserver
    {
        public override void Notification() => Console.WriteLine("Message to Employee => The price of the product has changed!");
    }
}
