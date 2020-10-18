namespace DesignPattern.Decorator
{
    public abstract class CarComponent : IComponent
    {
        public abstract string Description { get; }
        public abstract int Price { get; }
    }
}