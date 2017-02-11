using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tino = new TinoShop();
            tino.OrderPizza("meat");
            tino.OrderPizza("veggie");
            Console.WriteLine();

            var jazz = new JazzShop();
            jazz.OrderPizza("meat");
            jazz.OrderPizza("veggie");

            Console.ReadLine();
        }
    }
}
