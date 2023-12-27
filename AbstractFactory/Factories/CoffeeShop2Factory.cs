using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class CoffeeShop2Factory : IAbstractFactory
    {
        public ITea CreateTea()
        {
            return new LeaveTea();
        }

        public ICoffee CreateCoffee()
        {
            return new RedCatuaiCoffee();
        }
    }
}
