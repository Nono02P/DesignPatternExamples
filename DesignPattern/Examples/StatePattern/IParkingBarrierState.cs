namespace DesignPattern.State
{
    public interface IParkingBarrierState
    {
        void Enter();
        void Pay();
        void DoWork();
    }

    public enum ePaymentResult
    {
        Ok,
        Failed,
    }
}