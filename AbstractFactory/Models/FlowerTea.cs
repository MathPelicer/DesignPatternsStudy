using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    internal class FlowerTea : ITea
    {
        public string GetcaffeinatedTea(ICoffee abstractCoffee)
        {
            return $"you can get a caffeinated tea with {abstractCoffee.GetTaste()}";
        }

        string ITea.GetType()
        {
            return "Flower based tea";
        }
    }
}
