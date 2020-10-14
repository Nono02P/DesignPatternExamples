using DesignPattern.Strategy;
using System;

namespace DesignPattern
{
    public class StrategyExample : IDesignPatternExample
    {
        public void GetDescription()
        {
            Console.WriteLine("A utiliser lorsqu'une famille d'objet/d'algorithme peut faire une même action de différentes manières.");
            Console.WriteLine("L'implémentation du design pattern Strategy permet de facilement réutiliser/interchanger un comportement pour un objet/algorithme donné.");
            Console.WriteLine();
            Console.WriteLine("Par exemple, pour faire le tri dans une liste il existe plusieurs algorithmes qui permettent tous de faire un tri mais de manière différente.");
            Console.WriteLine("On passerait alors par une interface ISorting qui oblige à implémenter une méthode pour faire le tri.");
            Console.WriteLine("En faisant ainsi, la classe ayant besoin de trier n'a pas lieu de connaitre la méthode de tri on peut alors lui injecter dans le constructeur.");
            Console.WriteLine("Et il est donc plus facile de changer la manière de faire le tri puisqu'il suffit de donner une autre implémentation de la méthode de tri.");
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Dans cet exemple, nous avons différents types de canards.");
            Console.WriteLine("Chaque canard implémente un comportement pour voler, et un comportement pour faire du bruit.");
            Console.WriteLine("Le DoggyDuck et le RubberDuck partagent la même manière de voler (le même code) mais pas la même manière de faire du bruit.");
            Console.WriteLine("On voit qu'il est alors facile de réutiliser un comportement pour un canard sans avoir à multiplier le code.");
            Console.WriteLine("****************************************************");
            Console.WriteLine();
        }

        public void RunExample()
        {
            Execute(new FrenchDuck());
            Execute(new BelgiumDuck());
            Execute(new DoggyDuck());
            Execute(new RubberDuck());
        }

        private void Execute(BaseDuck duck)
        {
            Console.WriteLine($"{duck.GetType().Name} :");

            duck.Fly();
            duck.MakeSound();

            Console.WriteLine();
        }
    }
}