using Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Concrete
{
    public class PremiumUser : IUser
    {
        private string _userName;
        private IChatMediator _chatMediator;
        public PremiumUser(IChatMediator chatMediator, string userName)
        {
            this._chatMediator = chatMediator;
            this._userName = userName;
        }
        public void ReceiveMessage(string text) => Console.WriteLine($"User Type: Premium Member\nUser Name: {_userName}\nReceived Message {text}");
        public void SendMessage(string text) => _chatMediator.Send(text, this);
    }
}
