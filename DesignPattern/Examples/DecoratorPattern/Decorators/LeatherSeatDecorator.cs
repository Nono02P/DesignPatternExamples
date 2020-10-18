namespace DesignPattern.Decorator
{
    public class LeatherSeatDecorator : IDecorator
    {
        public IComponent Component { get; }
        public string Description => $"{Component.Description} + Siège cuir";
        public int Price => Component.Price + 400;

        public LeatherSeatDecorator(IComponent pComponent) { Component = pComponent; }
    }
}