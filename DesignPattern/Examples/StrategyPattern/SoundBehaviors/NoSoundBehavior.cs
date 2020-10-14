using System;

namespace DesignPattern.Strategy
{
    public class NoSoundBehavior : ISoundBehavior
    {
        public void MakeSound()
        {
            Console.WriteLine("* Silence *");
            ;
        }
    }
}