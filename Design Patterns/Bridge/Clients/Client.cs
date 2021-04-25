using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clients
{
    public class Client
    {
        private IBridge _bridge;
        public Client(IBridge bridge) => _bridge = bridge;
        public string Operation() => $"provided with  <===Bridge====> {_bridge.OperationImp()} abstract base!";

    }
}
