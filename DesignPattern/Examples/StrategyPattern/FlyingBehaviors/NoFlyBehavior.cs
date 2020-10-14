using System;

namespace DesignPattern.Strategy
{
    public class NoFlyBehavior : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Je ne sais pas voler !!");
        }
    }
}