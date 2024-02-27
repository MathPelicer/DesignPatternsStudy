using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IAbstractFactory
    {
        public IMilkyDrink CreateMilkyDrink();

        public ICoffee CreateCoffee();
    }
}
