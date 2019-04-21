using System;
namespace PizzaStore
{
    public class HUEGreekPizza : Pizza
    {
        public HUEGreekPizza()
        {
            name = "HUE A good greek pizza";
            dough = "HUE Thin dough";
            sauce = "HUE Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
