using System;

namespace SimpleFactoryPattern
{
    static class SimplePizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            var ingredientFactory = new PizzaIngredientFactory();
            switch (type)
            {
                case "meat":
                    return new MeatPizza(ingredientFactory);
                case "veggie":
                    return new VeggiePizza(ingredientFactory);
                default:
                    return null;
            }
        }
    }
}
