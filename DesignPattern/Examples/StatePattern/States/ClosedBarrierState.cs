using System;

namespace DesignPattern.State
{
    public class ClosedBarrierState : IParkingBarrierState
    {
        private ParkingBarrier _barrier;

        public ClosedBarrierState(ParkingBarrier barrier)
        {
            _barrier = barrier;
        }

        public void DoWork()
        {
            Console.WriteLine("MAJ de l'état barrière fermée : lumière rouge allumée.");
        }

        public void Enter()
        {
            Console.WriteLine("Tu cherches à entrer dans le parking, alors que t'es déjà dedans. Je ne fait donc rien.");
        }

        public void Pay()
        {
            Console.WriteLine("Transition dans le processus de paiement.");
            _barrier.BarrierState = new PaymentBarrierState(_barrier);
        }
    }
}