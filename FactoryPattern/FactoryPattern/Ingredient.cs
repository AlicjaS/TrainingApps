using System;

namespace SimpleFactoryPattern
{
    abstract class Ingredient
    {
        public abstract void AddIngredient();
    }

    class Cheese : Ingredient
    {
        public override void AddIngredient()
        {
            Console.WriteLine($"Cheese type: {GetType().Name} added");
        }
    }

    class Mozarella : Cheese
    { }

    class Parmezan : Cheese
    { }

    class Meat : Ingredient
    {
        public override void AddIngredient()
        {
            Console.WriteLine($"Meat type: {GetType().Name} added");
        }
    }

    class Ham : Meat
    { }

    class Salami : Meat
    { }

    class Veggie : Ingredient
    {
        public override void AddIngredient()
        {
            Console.WriteLine($"Veggie type: {GetType().Name} added");
        }
    }

    class Olives : Veggie
    { }

    class Pepper : Veggie
    { }
}
