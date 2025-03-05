using System;

namespace ConsoleApp3
{
    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video");
        }
    }
}
