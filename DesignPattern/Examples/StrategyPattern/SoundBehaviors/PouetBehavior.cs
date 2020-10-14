using System;

namespace DesignPattern.Strategy
{
    public class PouetBehavior : ISoundBehavior
    {
        public void MakeSound()
        {
            Console.WriteLine("Je fais ''Pouet pouet''");
            ;
        }
    }
}