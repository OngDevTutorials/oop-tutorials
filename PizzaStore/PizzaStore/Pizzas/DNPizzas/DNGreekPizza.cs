using System;
namespace PizzaStore
{
    public class DNGreekPizza : Pizza
    {
        public DNGreekPizza()
        {
            name = "DN A good greek pizza";
            dough = "DN Thin dough";
            sauce = "DN Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
