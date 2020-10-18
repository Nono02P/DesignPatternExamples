using DesignPattern.Decorator;
using System;

namespace DesignPattern
{
    public class DecoratorExample : IDesignPatternExample
    {
        public void GetDescription()
        {
            Console.WriteLine("A utiliser lorsqu'un objet a besoin d'étendre ses fonctionnalités en les attachant dynamiquement.");
            Console.WriteLine();
            Console.WriteLine("Le design pattern Decorator, sert à 'décorer' un composant avec des 'décorations'.");
            Console.WriteLine("Le principe est d'avoir une interface IComponent et une interface IDecorator qui contient et implémente un IComponent.");
            Console.WriteLine("On définit alors des classes concrètes qui implémentent IComponent.");
            Console.WriteLine("Et on définit des decorator (des comportements) qui viendront s'attacher au component pour ajouter une couche supplémentaire.");
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Dans cet exemple, nous avons des voitures de marques différentes (Components).");
            Console.WriteLine("Et pour chaque voiture, il est possible de prendre des options (Decorators).");
            Console.WriteLine("Le component est alors capable de donner une description et un prix total incluant la voiture + les options.");
            Console.WriteLine("****************************************************");
            Console.WriteLine();
        }

        public void RunExample()
        {
            Execute(new SpareWheelDecorator(new LeatherSeatDecorator(new HeatedSeatDecorator(new HeatedSeatDecorator(new VolkswagenCarComponent())))));
            Execute(new SpareWheelDecorator(new ClimatisationDecorator(new PeugeotCarComponent())));
            Execute(new LeatherSeatDecorator(new RenaultCarComponent()));
        }

        private void Execute(IComponent component)
        {
            Console.WriteLine(component.Description);
            Console.WriteLine(component.Price + "Euros");
        }
    }
}