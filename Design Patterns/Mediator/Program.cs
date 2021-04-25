using Mediator.Concrete;
using Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser michael = new BasicUser(chatMediator, "hall of fame");
            IUser majesty = new GoldUser(chatMediator, "greatest of all time");
            IUser jordan = new PremiumUser(chatMediator, "space jam");

            chatMediator.AddUser(michael);
            chatMediator.AddUser(majesty);
            chatMediator.AddUser(jordan);

            michael.SendMessage("GOAT!!!!");
        }
    }
}
