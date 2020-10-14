namespace DesignPattern.Strategy
{
    public class RubberDuck : BaseDuck
    {
        public RubberDuck() : base (new NoFlyBehavior(), new NoSoundBehavior()) { }
    }
}