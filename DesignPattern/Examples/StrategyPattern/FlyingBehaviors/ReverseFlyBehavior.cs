using System;

namespace DesignPattern.Strategy
{
    public class ReverseFlyBehavior : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Je vole à l'envers (sur le dos).");
        }
    }
}