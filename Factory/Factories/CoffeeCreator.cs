using Factory.Models;
using Factory.Models.Interfaces;

namespace Factory.Factories
{
    public class CoffeeCreator : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new Coffee();
        }
    }
}
