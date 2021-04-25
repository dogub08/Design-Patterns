using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerHandler aviPlayer = new HandlerAvi();
            PlayerHandler mp3Player = new HandlerMp3();
            PlayerHandler mp4Player = new HandlerMp4();

            mp3Player.NextHandler = mp4Player;
            mp4Player.NextHandler = aviPlayer;

            mp3Player.PlayMedia("video.mpg");
            mp3Player.PlayMedia("video.avi");
            mp3Player.PlayMedia("video.mp4");
            mp3Player.PlayMedia("video.zzz");
            mp3Player.PlayMedia("video.mp3");
        }
    }
}
