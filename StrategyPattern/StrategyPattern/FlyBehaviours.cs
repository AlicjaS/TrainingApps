using System;

namespace StrategyPattern
{
    class FlyWithWings : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }

    class FlyNoWay : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Fly no way");
        }
    }

    class FlyWithRocket : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("Fly with rocket");
        }
    }

    interface IFlyBehaviour
    {
        void fly();
    }
}
