namespace DesignPattern.Decorator
{
    public interface IDecorator : IComponent
    {
        IComponent Component { get; }
    }
}