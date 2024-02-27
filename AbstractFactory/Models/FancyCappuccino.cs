using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    internal class FancyCappuccino : IMilkyDrink
    {
        public string GetCaffeinatedDrink(ICoffee abstractCoffee)
        {
            return $"you get a fancy italian cappuccino made with a {abstractCoffee.GetTaste()}";
        }

        string IMilkyDrink.GetType()
        {
            return "a fancy cappuccino, that's distinguish!";
        }
    }
}
