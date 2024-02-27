using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Models.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class CozyCoffeeShop : IAbstractFactory
    {
        public IMilkyDrink CreateMilkyDrink()
        {
            return new CozyChocolateMilk();
        }

        public ICoffee CreateCoffee()
        {
            return new CozyMokaPot();
        }
    }
}
