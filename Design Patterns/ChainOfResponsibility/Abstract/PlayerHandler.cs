using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Abstract
{
    public abstract class PlayerHandler
    {
        protected PlayerHandler _nextHandler;
        public PlayerHandler NextHandler { set => _nextHandler = value; }
        public abstract void PlayMedia(string mediaType);
    }
}
