using System;
namespace PizzaStore
{
    public class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "HCM A good greek pizza";
            dough = "HCM Thin dough";
            sauce = "HCM Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
