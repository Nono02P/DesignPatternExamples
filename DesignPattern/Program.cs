using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesignPatternExample pattern = null;

            Console.WriteLine("Tapez 0 pour le design pattern Strategy");
            Console.WriteLine("Tapez 1 pour le design pattern State");
            //Console.WriteLine("Tapez 2 pour le design pattern Decorator");
            //Console.WriteLine("Tapez 3 pour le design pattern Observer");
            //Console.WriteLine("Tapez 4 pour le design pattern Factory");
            //Console.WriteLine("Tapez 5 pour le design pattern Builder");
            //Console.WriteLine("Tapez 6 pour le design pattern Prototype");
            //Console.WriteLine("Tapez 7 pour le design pattern Singleton");
            //Console.WriteLine("Tapez 8 pour le design pattern Adapter");
            //Console.WriteLine("Tapez 9 pour le design pattern Bridge");
            //Console.WriteLine("Tapez 10 pour le design pattern Composite");
            //Console.WriteLine("Tapez 11 pour le design pattern Facade");
            //Console.WriteLine("Tapez 12 pour le design pattern Flyweight");
            //Console.WriteLine("Tapez 13 pour le design pattern Proxy");
            //Console.WriteLine("Tapez 14 pour le design pattern Interpreter");
            //Console.WriteLine("Tapez 15 pour le design pattern Template Method");
            //Console.WriteLine("Tapez 16 pour le design pattern Chain Of Responsability");
            //Console.WriteLine("Tapez 17 pour le design pattern Command");
            //Console.WriteLine("Tapez 18 pour le design pattern Iterator");
            //Console.WriteLine("Tapez 19 pour le design pattern Mediator");
            //Console.WriteLine("Tapez 20 pour le design pattern Memento");
            //Console.WriteLine("Tapez 21 pour le design pattern Visitor");

            Console.WriteLine("Tapez autre chose pour quitter");

            string line = Console.ReadLine();

            Console.Clear();

            switch (line)
            {
                case "0":
                    pattern = new StrategyExample();
                    break;
                case "1":
                    pattern = new StateExample();
                    break;
                case "2":
                    //pattern = new DecoratorExample();
                    break;
                case "3":
                    //pattern = new ObserverExample();
                    break;
                case "4":
                    //pattern = new FactoryExample();
                    break;
                case "5":
                    //pattern = new BuilderExample();
                    break;
                case "6":
                    //pattern = new PrototypeExample();
                    break;
                case "7":
                    //pattern = new SingletonExample();
                    break;
                case "8":
                    //pattern = new AdapterExample();
                    break;
                case "9":
                    //pattern = new BridgeExample();
                    break;
                case "10":
                    //pattern = new CompositeExample();
                    break;
                case "11":
                    //pattern = new FacadeExample();
                    break;
                case "12":
                    //pattern = new FlyweightExample();
                    break;
                case "13":
                    //pattern = new ProxyExample();
                    break;
                case "14":
                    //pattern = new InterpreterExample();
                    break;
                case "15":
                    //pattern = new TemplateMethodExample();
                    break;
                case "16":
                    //pattern = new ChainOfResponsabilityExample();
                    break;
                case "17":
                    //pattern = new CommandExample();
                    break;
                case "18":
                    //pattern = new IteratorExample();
                    break;
                case "19":
                    //pattern = new MediatorExample();
                    break;
                case "20":
                    //pattern = new MementoExample();
                    break;
                case "21":
                    //pattern = new VisitorExample();
                    break;
                default:
                    break;
            }
            
            pattern?.GetDescription();
            pattern?.RunExample();

            if (pattern != null)
                Console.ReadKey();
        }
    }
}