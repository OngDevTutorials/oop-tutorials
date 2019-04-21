using System;
namespace PizzaStore
{
    public class HCMPepperoniPizza : Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "HCM The best pepperoni pizza";
            dough = "HCM Thick dough";
            sauce = "HCM Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
