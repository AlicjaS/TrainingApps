namespace SimpleFactoryPattern
{
    abstract class PizzaShop
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }

    class SimplePizzaShop : PizzaShop
    {
        protected override Pizza CreatePizza(string type)
        {
            return SimplePizzaFactory.CreatePizza(type);
        }
    }

    class TinoShop : PizzaShop
    {
        protected override Pizza CreatePizza(string type)
        {
            var ingredientFactory = new TinoIngredientFactory();
            switch (type)
            {
                case "meat":
                    return new TinoMeatPizza(ingredientFactory);
                case "veggie":
                    return new TinoVeggiePizza(ingredientFactory);
                default:
                    return null;
            }
        }
    }

    class JazzShop : PizzaShop
    {
        protected override Pizza CreatePizza(string type)
        {
            var ingredientFactory = new JazzIngredientFactory();
            switch (type)
            {
                case "meat":
                    return new JazzMeatPizza(ingredientFactory);
                case "veggie":
                    return new JazzVeggiePizza(ingredientFactory);
                default:
                    return null;
            }
        }
    }
}
