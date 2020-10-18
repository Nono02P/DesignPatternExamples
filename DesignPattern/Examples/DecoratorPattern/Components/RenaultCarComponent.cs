namespace DesignPattern.Decorator
{
    public class RenaultCarComponent : CarComponent
    {
        public override string Description => "Voiture Renault";
        public override int Price => 5000;
    }
}