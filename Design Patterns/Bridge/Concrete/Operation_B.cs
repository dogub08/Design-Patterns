using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Concrete
{
    public class Operation_B : IBridge
    {
        public string OperationImp() => "Operation B has been performed..!";
    }
}
