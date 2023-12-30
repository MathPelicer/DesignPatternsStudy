using Factory.Models.Interfaces;

namespace Factory.Models
{
    public class Coffee : IProduct
    {
        public string Operation()
        {
            return "Coffee product";
        }
    }
}
