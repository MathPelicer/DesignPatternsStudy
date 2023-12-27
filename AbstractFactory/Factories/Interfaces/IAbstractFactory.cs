using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IAbstractFactory
    {
        public ITea CreateTea();

        public ICoffee CreateCoffee();
    }
}
