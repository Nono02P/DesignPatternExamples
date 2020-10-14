using System;

namespace DesignPattern.Strategy
{
    public class NormalFlyBehavior : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Je vole à l'endroit.");
        }
    }
}