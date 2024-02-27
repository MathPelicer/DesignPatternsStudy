using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class CozyChocolateMilk : IMilkyDrink
    {
        public string GetCaffeinatedDrink(ICoffee abstractCoffee)
        {
            return $"you can get a warm mocca, made with {abstractCoffee.GetTaste()} and chocolate milk, it feels like a hug";
        }

        string IMilkyDrink.GetType()
        {
            return "a warm mocca, fells like a hug ";
        }
    }
}
