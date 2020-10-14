namespace DesignPattern.State
{
    public class ParkingBarrier
    {
        public IParkingBarrierState BarrierState { get; set; }
        public IPaymentService PaymentService { get; set; }

        public ParkingBarrier(IPaymentService paymentService)
        {
            BarrierState = new OpenedBarrierState(this);
            PaymentService = paymentService;
        }

        public void Update()
        {
            BarrierState.DoWork();
        }

        public void CustomerEntrance()
        {
            BarrierState.Enter();
        }

        public void CustomerPayment()
        {
            BarrierState.Pay();
        }
    }
}