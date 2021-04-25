using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class HandlerMp3 : PlayerHandler
    {
        public override void PlayMedia(string mediaType)
        {
            if (mediaType.EndsWith(".mp3"))
                Console.WriteLine($"{mediaType} media type is playing..!");
            else
            {
                if (_nextHandler != null)
                    _nextHandler.PlayMedia(mediaType);
            }
        }
    }
}
