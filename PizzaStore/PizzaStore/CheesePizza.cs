using System;
namespace PizzaStore
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "The best cheese pizza";
            dough = "Very thin dough";
            sauce = "Very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }

        public override void Box()
        {
            Console.WriteLine(dough);
        }
    }
}
