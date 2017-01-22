using System;

namespace StrategyPattern
{
    abstract class Duck
    {
        protected IFlyBehaviour FlyBehaviour;
        protected IQuackBehaviour QuackBehaviour;

        public void PerformFly()
        {
            FlyBehaviour.fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.quack();
        }

        public virtual void Display()
        {
            Console.WriteLine("Duck of type: {0}", GetType());
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            FlyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            QuackBehaviour = quackBehaviour;
        }
    }
}
