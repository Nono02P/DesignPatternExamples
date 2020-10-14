namespace DesignPattern.Strategy
{
    public abstract class BaseDuck
    {
        private IFlyingBehavior _flyingBehavior;
        private ISoundBehavior _soundBehavior;

        public BaseDuck(IFlyingBehavior flyingBehavior, ISoundBehavior soundBehavio)
        {
            _flyingBehavior = flyingBehavior;
            _soundBehavior = soundBehavio;
        }

        public void Fly()
        {
            _flyingBehavior.Fly();
        }

        public void MakeSound()
        {
            _soundBehavior.MakeSound();
        }
    }
}