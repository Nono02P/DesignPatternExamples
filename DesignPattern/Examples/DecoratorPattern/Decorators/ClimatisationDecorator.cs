namespace DesignPattern.Decorator
{
    public class ClimatisationDecorator : IDecorator
    {
        public IComponent Component { get; }
        public string Description => $"{Component.Description} + Climatisation";
        public int Price => Component.Price + 1500;

        public ClimatisationDecorator(IComponent pComponent) { Component = pComponent; }
    }
}