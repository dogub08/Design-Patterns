using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    public class Decorator_B : IComponent
    {
        private IComponent _component;

        public Decorator_B(IComponent component) => _component = component;

        public string Operation() => _component.Operation() + "I am developing C ++ projects ..!";
    }
}
