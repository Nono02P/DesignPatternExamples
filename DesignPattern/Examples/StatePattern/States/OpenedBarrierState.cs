using System;

namespace DesignPattern.State
{
    public class OpenedBarrierState : IParkingBarrierState
    {
        private ParkingBarrier _barrier;

        public OpenedBarrierState(ParkingBarrier barrier)
        {
            _barrier = barrier;
        }

        public void DoWork()
        {
            Console.WriteLine("MAJ de l'état barrière ouverte : La lumière est allumée verte.");
        }

        public void Enter()
        {
            Console.WriteLine("Entrée dans le parking, transition dans l'état fermé.");
            _barrier.BarrierState = new ClosedBarrierState(_barrier);
        }

        public void Pay()
        {
            Console.WriteLine("Tu veut payer alors que la barrière est déjà ouverte. Tu serais pas un peu con?");
        }
    }
}