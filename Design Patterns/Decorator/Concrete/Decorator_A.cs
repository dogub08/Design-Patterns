using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    public class Decorator_A : IComponent
    {
        private IComponent _component;

        public Decorator_A(IComponent component) => _component = component;

        public string Operation() => _component.Operation() + "I'm developing asp .net projects ..!";
    }
}
