using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Interface
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void Send(string message, IUser sender);
    }
}
