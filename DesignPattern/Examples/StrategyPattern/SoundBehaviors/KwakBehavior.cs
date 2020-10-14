using System;

namespace DesignPattern.Strategy
{
    public class KwakBehavior : ISoundBehavior
    {
        public void MakeSound()
        {
            Console.WriteLine("Je fais ''Kwak''");
            ;
        }
    }
}