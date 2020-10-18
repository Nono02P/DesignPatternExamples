namespace DesignPattern.Decorator
{
    public class PeugeotCarComponent : CarComponent
    {
        public override string Description => "Voiture Peugeot";
        public override int Price => 6000;
    }
}