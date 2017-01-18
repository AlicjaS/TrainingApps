using System;
using System.Collections.Generic;
using System.IO;

namespace Train01
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = CreateDucks();

            ducks[0].SetQuackBehaviour(new Squeak());

            DisplayDucks(ducks);

            Console.ReadLine();
        }

        private static void DucksToText()
        {
            using (var filestream = new FileStream(@"C:\Test\DuckOut.txt", FileMode.Create))
            {
                using (var streamwriter = new StreamWriter(filestream))
                {
                    streamwriter.AutoFlush = true;
                    Console.SetOut(streamwriter);
                    DuckCheck();
                }
            }
        }

        private static void DuckCheck()
        {
            List<Duck> ducks = CreateDucks();
            DisplayDucks(ducks);
        }

        private static void DisplayDucks(List<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
            }
        }

        private static List<Duck> CreateDucks()
        {
            var ducks = new List<Duck>();
            ducks.Add(new RocketDuck());
            ducks.Add(new BlackDuck());
            ducks.Add(new RubberDuck());
            ducks.Add(new WoodDuck());
            ducks.Add(new PrettyDuck());
            return ducks;
        }
    }
}
