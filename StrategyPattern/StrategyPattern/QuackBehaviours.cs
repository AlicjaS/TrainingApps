﻿using System;

namespace StrategyPattern
{
    class Quack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }

    class Squeak : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    class MuteQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("MuteQuack");
        }
    }

    interface IQuackBehaviour
    {
        void quack();
    }
}
