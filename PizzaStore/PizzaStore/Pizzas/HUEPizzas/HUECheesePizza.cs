using System;
namespace PizzaStore
{
    public class HUECheesePizza : Pizza
    {
        public HUECheesePizza()
        {
            name = "HUE The best cheese pizza";
            dough = "HUE Very thin dough";
            sauce = "HUE Very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }
    }
}
