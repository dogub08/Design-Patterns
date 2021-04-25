using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    public class SingletonClass
    {
        private SingletonClass() { }
        private static SingletonClass _singletonClass = new SingletonClass();
        public static SingletonClass singleClass { get => _singletonClass; }
        public int Addition(int s1, int s2) => s1 + s2;

    }
}
