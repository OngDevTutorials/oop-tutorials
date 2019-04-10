using System;
namespace PizzaStore
{
    public class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "greek":
                    pizza = new GreekPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("We do not have " + type + " pizza");
                    return;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
