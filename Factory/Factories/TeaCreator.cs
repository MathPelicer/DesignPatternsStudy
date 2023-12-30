using Factory.Models.Interfaces;
using Factory.Models;

namespace Factory.Factories
{
    public class TeaCreator : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new Tea();
        }
    }
}
