namespace DesignPattern.Strategy
{
    public class DoggyDuck : BaseDuck
    {
        public DoggyDuck() : base (new NoFlyBehavior(), new PouetBehavior()) { }
    }
}