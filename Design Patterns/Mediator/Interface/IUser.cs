using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interface
{
    public interface IUser
    {
        void SendMessage(string text);
        void ReceiveMessage(string text);
    }
}
