using System;
using System.Collections.Generic;

namespace SimpleFactoryPattern
{
    abstract class Pizza
    {
        protected List<Ingredient> _ingredients;
        protected IPizzaIngredientFactory _ingredientFactory;

        public Pizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            _ingredients = new List<Ingredient>();
        }

        public abstract void Prepare();

        public virtual void Bake() => Console.WriteLine($"{GetType().Name} bake");
        public virtual void Box() => Console.WriteLine($"{GetType().Name} box");
    }

    class MeatPizza : Pizza
    {
        public MeatPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }

        public override void Prepare()
        {
            _ingredients.Add(_ingredientFactory.CreateMeat());
            _ingredients.Add(_ingredientFactory.CreateCheese());
        }
    }

    class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }

        public override void Prepare()
        {
            _ingredients.Add(_ingredientFactory.CreateVeggie());
            _ingredients.Add(_ingredientFactory.CreateCheese());
        }
    }

    class TinoMeatPizza : MeatPizza
    {
        public TinoMeatPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }

    class TinoVeggiePizza : VeggiePizza
    {
        public TinoVeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }

    class JazzMeatPizza : MeatPizza
    {
        public JazzMeatPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }

    class JazzVeggiePizza : VeggiePizza
    {
        public JazzVeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }
}
