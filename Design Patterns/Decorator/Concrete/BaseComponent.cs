using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    public class BaseComponent : IComponent
    {
        public string Operation() => "For the company I work for..";
    }
}
