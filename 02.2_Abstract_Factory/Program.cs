﻿// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();
            
            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.WriteLine("");
        }

    }
}

