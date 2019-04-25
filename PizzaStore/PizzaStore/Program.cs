using PizzaStore.Store;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore;

            pizzaStore = new HUEPizzaStore();
            pizzaStore.OrderPizza("cheese");

            pizzaStore = new DNPizzaStore();
            pizzaStore.OrderPizza("cheese");

            pizzaStore = new HCMPizzaStore();
            pizzaStore.OrderPizza("cheese");
        }
    }
}
