using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class LeaveTea : ITea
    {
        public string GetCaffeinatedTea(ICoffee abstractCoffee)
        {
            return $"you can get a caffeinated tea with {abstractCoffee.GetTaste()}";
        }

        string ITea.GetType()
        {
            return "Leave based tea";
        }
    }
}
