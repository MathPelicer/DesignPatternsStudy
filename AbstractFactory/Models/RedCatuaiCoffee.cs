using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class RedCatuaiCoffee : ICoffee
    {
        public string GetTaste()
        {
            return "Red Catuai Type Coffee";
        }
    }
}
