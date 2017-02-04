using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckDecoratorPattern();

            Console.ReadLine();
        }

        static void CheckDecoratorPattern()
        {
            var myCoffee = new Whip(new Milk(new Americano()));
            Console.WriteLine(myCoffee.Description);
            Console.WriteLine("MyCoffee costs: {0:C}", myCoffee.Cost());
        }
    }
}
