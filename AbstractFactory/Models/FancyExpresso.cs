using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class FancyExpresso : ICoffee
    {
        string ICoffee.GetTaste()
        {
            return "a fancy expresso shot";
        }
    }
}
