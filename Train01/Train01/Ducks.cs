using System;

namespace Train01
{
    class BlackDuck : Duck
    {
        public BlackDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quack();
        }
    }

    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Squeak();
        }
    }

    class WoodDuck : Duck
    {
        public WoodDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new MuteQuack();
        }
    }

    class RocketDuck : Duck
    {
        public RocketDuck()
        {
            FlyBehaviour = new FlyWithRocket();
            QuackBehaviour = new MuteQuack();
        }
    }

    class PrettyDuck : Duck
    {
        public PrettyDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am Pretty Duck");
        }
    }
}
