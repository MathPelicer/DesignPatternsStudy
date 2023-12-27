namespace AbstractFactory.Models.Interfaces
{
    public interface ITea
    {
        public string GetType();

        public string GetcaffeinatedTea(ICoffee abstractCoffee);
    }
}
