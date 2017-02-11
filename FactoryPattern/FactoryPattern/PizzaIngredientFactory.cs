namespace SimpleFactoryPattern
{
    interface IPizzaIngredientFactory
    {
        Cheese CreateCheese();
        Meat CreateMeat();
        Veggie CreateVeggie();
    }

    class PizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            var cheese = new Cheese();
            cheese.AddIngredient();
            return cheese;
        }

        public Meat CreateMeat()
        {
            var meat = new Meat();
            meat.AddIngredient();
            return meat;
        }

        public Veggie CreateVeggie()
        {
            var veggie = new Veggie();
            veggie.AddIngredient();
            return veggie;
        }
    }

    class TinoIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            var cheese = new Mozarella();
            cheese.AddIngredient();
            return cheese;
        }

        public Meat CreateMeat()
        {
            var meat = new Ham();
            meat.AddIngredient();
            return meat;
        }

        public Veggie CreateVeggie()
        {
            var veggie = new Pepper();
            veggie.AddIngredient();
            return veggie;
        }
    }

    class JazzIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            var cheese = new Parmezan();
            cheese.AddIngredient();
            return cheese;
        }

        public Meat CreateMeat()
        {
            var meat = new Salami();
            meat.AddIngredient();
            return meat;
        }

        public Veggie CreateVeggie()
        {
            var veggie = new Olives();
            veggie.AddIngredient();
            return veggie;
        }
    }
}
