namespace AbstractFactory.Models.Interfaces
{
    public interface IMilkyDrink
    {
        public string GetType();

        public string GetCaffeinatedDrink(ICoffee abstractCoffee);
    }
}
