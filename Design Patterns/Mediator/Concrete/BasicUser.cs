using Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Concrete
{
    public class BasicUser : IUser
    {
        string _userName;
        IChatMediator _chatMediator;
        public BasicUser(IChatMediator chatMediator, string username)
        {
            this._chatMediator = chatMediator;
            this._userName = username;
        }

        public void ReceiveMessage(string text) => Console.WriteLine($"User Type: Basic \n User Name: {_userName}\nReceived Message: {text}");

        public void SendMessage(string text) => _chatMediator.Send(text, this);
    }
}
