using System;
namespace PizzaStore
{
    public class DNCheesePizza : Pizza
    {
        public DNCheesePizza()
        {
            name = "DN The best cheese pizza";
            dough = "DN Very thin dough";
            sauce = "DN Very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }
    }
}
