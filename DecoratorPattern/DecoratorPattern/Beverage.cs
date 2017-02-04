namespace DecoratorPattern
{
    abstract class Beverage
    {
        public abstract string Description { get; }

        public abstract int Cost();
    }

    class IceTea : Beverage
    {
        public override string Description => "Ice Tea";

        public override int Cost() => 12;
    }

    class Espresso : Beverage
    {
        public override string Description => "Espresso coffee";

        public override int Cost() => 10;
    }

    class Americano : Beverage
    {
        public override string Description => "Americano coffee";

        public override int Cost() => 10;
    }
}
