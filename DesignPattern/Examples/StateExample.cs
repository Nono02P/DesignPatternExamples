using DesignPattern.State;
using System;

namespace DesignPattern
{
    public class StateExample : IDesignPatternExample
    {
        public void GetDescription()
        {
            Console.WriteLine("A utiliser lorsqu'un objet a besoin d'exécuter un comportement différent en fonction de son état.");
            Console.WriteLine("L'implémentation du design pattern State permet de gérer facilement les actions en fonction de l'état et les transitions d'un état à un autre.");
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Dans cet exemple, nous avons une barrière de parking.");
            Console.WriteLine("Lorsqu'elle est ouverte, et qu'un client entre dans le parking, elle se referme.");
            Console.WriteLine("Une fois la barrière fermée, le client doit engager un processus de paiement pour pouvoir ressortir.");
            Console.WriteLine(" => Si le paiement est accepté, la barrière s'ouvre.");
            Console.WriteLine(" => Si le paiement est refusé, la barrière reste fermée.");
            Console.WriteLine("****************************************************");
            Console.WriteLine();
        }

        public void RunExample()
        {
            ParkingBarrier parkingBarrier = new ParkingBarrier(new PaymentService());
            parkingBarrier.Update();
            parkingBarrier.CustomerEntrance();

            parkingBarrier.Update();
            parkingBarrier.CustomerPayment();

            parkingBarrier.Update();
        }
    }
}