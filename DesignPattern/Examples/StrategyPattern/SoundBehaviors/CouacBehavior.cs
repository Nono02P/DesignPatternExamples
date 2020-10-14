using System;

namespace DesignPattern.Strategy
{
    public class CouacBehavior : ISoundBehavior
    {
        public void MakeSound()
        {
            Console.WriteLine("Je fais ''Couac''");
            ;
        }
    }
}