using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models;
using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Factories
{
    public class CoffeeShop1Factory : IAbstractFactory
    {
        public ITea CreateTea()
        {
            return new FlowerTea();
        }

        public ICoffee CreateCoffee()
        {
            return new ArabicaCoffee();
        }
    }
}
