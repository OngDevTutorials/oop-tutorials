using System;
namespace PizzaStore
{
    public class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            name = "HCM The best cheese pizza";
            dough = "HCM Very thin dough";
            sauce = "HCM Very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }
    }
}
