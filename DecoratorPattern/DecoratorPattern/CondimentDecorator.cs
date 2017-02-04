namespace DecoratorPattern
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }

    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => _beverage.Description + " plus Milk";

        public override int Cost() => _beverage.Cost() + 2;
    }

    class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => _beverage.Description + " plus Whip";

        public override int Cost() => _beverage.Cost() + 3;
    }
}
