namespace DesignPattern.Strategy
{
    public class BelgiumDuck : BaseDuck
    {
        public BelgiumDuck() : base (new ReverseFlyBehavior(), new KwakBehavior()) { }
    }
}