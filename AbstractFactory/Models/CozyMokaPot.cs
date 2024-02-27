using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class CozyMokaPot : ICoffee
    {
        public string GetTaste()
        {
            return "a cozy moka pot coffee, like the one grany would make";
        }
    }
}
