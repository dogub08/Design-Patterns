using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class HandlerAvi : PlayerHandler
    {
        public override void PlayMedia(string mediaType)
        {
            if (mediaType.EndsWith(".avi"))
                Console.WriteLine($"{mediaType}media type is playing..!");
            else
                Console.WriteLine("Invalid file format..!");
        }
    }
}
