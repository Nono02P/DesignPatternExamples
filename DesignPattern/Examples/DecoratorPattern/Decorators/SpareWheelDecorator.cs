namespace DesignPattern.Decorator
{
    public class SpareWheelDecorator : IDecorator
    {
        public IComponent Component { get; }
        public string Description => $"{Component.Description} + Roue de secours";
        public int Price => Component.Price + 200;

        public SpareWheelDecorator(IComponent pComponent) { Component = pComponent; }
    }
}