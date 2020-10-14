using System;

namespace DesignPattern.State
{
    public class PaymentBarrierState : IParkingBarrierState
    {
        private ParkingBarrier _barrier;

        public PaymentBarrierState(ParkingBarrier barrier)
        {
            _barrier = barrier;
        }

        public void DoWork()
        {
            Console.WriteLine("MAJ de l'état paiement : La lumière clignote jaune.");
            Console.WriteLine("Début du processus de paiement...");
            switch (_barrier.PaymentService.Pay())
            {
                case ePaymentResult.Failed:
                    Console.WriteLine("Le paiement a échoué, transition dans l'état barrière fermée.");
                    _barrier.BarrierState = new ClosedBarrierState(_barrier);
                    break;

                case ePaymentResult.Ok:
                    Console.WriteLine("Le paiement est accepté, transition dans l'état barrière ouverte.");
                    _barrier.BarrierState = new OpenedBarrierState(_barrier);
                    break;

                default:
                    break;
            }
        }

        public void Enter()
        {
            Console.WriteLine("Tu cherches à entrer dans le parking alors que t'es en train de payer pour en sortir. Je ne fait donc rien.");
        }

        public void Pay()
        {
            Console.WriteLine("T'es déjà en train de payer. Je ne fait fonc rien.");
        }
    }
}