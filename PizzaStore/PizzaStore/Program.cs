using System;
using System.Collections.Generic;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("greek");
            pizzaStore.OrderPizza("pepperoni");
            pizzaStore.OrderPizza("ongdev");
        }
    }
}
