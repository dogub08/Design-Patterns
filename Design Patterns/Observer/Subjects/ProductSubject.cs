using Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subjects
{
    public class ProductSubject
    {
        List<BaseObserver> observers = new List<BaseObserver>();

        public void Update()
        {
            Console.WriteLine("The price of the product has changed..!");
            NotificationToAppUser();
        }

        public void Attachment(BaseObserver observer) => observers.Add(observer);
        public void Detachment(BaseObserver observer) => observers.Remove(observer);
        private void NotificationToAppUser()
        {
            foreach (BaseObserver observer in observers)
                observer.Notification();
        }
    }
}
