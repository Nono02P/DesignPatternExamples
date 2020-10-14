namespace DesignPattern.Strategy
{
    public class FrenchDuck : BaseDuck
    {
        public FrenchDuck() : base (new NormalFlyBehavior(), new CouacBehavior()) { }
    }
}