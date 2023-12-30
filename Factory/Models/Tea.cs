using Factory.Models.Interfaces;

namespace Factory.Models
{
    public class Tea : IProduct
    {
        public string Operation()
        {
            return "Tea product";
        }
    }
}
