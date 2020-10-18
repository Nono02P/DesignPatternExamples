namespace DesignPattern.Decorator
{
    public class HeatedSeatDecorator : IDecorator
    {
        public IComponent Component { get; }
        public string Description => $"{Component.Description} + Siège chauffant";
        public int Price => Component.Price + 150;

        public HeatedSeatDecorator(IComponent pComponent) { Component = pComponent; }
    }
}