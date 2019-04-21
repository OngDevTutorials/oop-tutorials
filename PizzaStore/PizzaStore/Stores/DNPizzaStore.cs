using System;
namespace PizzaStore.Store
{
    public class DNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new DNCheesePizza();
                case "greek":
                    return new DNGreekPizza();
                case "pepperoni":
                    return new DNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
