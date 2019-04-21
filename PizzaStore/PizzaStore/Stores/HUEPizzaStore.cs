using System;
namespace PizzaStore.Store
{
    public class HUEPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HUECheesePizza();
                case "greek":
                    return new HUEGreekPizza();
                case "pepperoni":
                    return new HUEPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
