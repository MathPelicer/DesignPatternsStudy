using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class ArabicaCoffee : ICoffee
    {
        string ICoffee.GetTaste()
        {
            return "Arabica Type Coffee";
        }
    }
}
