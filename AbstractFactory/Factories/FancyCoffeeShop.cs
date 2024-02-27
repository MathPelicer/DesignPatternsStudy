using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models;
using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Factories
{
    public class FancyCoffeeShop : IAbstractFactory
    {
        public IMilkyDrink CreateMilkyDrink()
        {
            return new FancyCappuccino();
        }

        public ICoffee CreateCoffee()
        {
            return new FancyExpresso();
        }
    }
}
