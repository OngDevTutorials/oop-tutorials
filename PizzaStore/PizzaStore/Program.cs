using PizzaStore.Store;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var huePizzaStore = new HUEPizzaStore();
            huePizzaStore.OrderPizza("cheese");
            var dnPizzaStore = new DNPizzaStore();
            dnPizzaStore.OrderPizza("cheese");
            var hcmPizzaStore = new HCMPizzaStore();
            hcmPizzaStore.OrderPizza("cheese");
        }
    }
}
