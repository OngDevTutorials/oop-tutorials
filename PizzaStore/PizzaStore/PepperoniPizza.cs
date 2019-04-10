using System;
namespace PizzaStore
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "The best pepperoni pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
