using Observer.Abstract;
using Observer.Concrete;
using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseObserver customerObserver = new CustomerObserver();
            BaseObserver employeeObserver = new EmployeeObserver();
            ProductSubject productSubject = new ProductSubject();

            productSubject.Attachment(customerObserver);
            productSubject.Attachment(employeeObserver);
            productSubject.Update();
        }
    }
}
