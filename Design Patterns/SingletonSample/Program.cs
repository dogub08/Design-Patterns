using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingletonClass.singleClass.Addition(8, 7));
            Console.ReadKey();
        }
    }
}
