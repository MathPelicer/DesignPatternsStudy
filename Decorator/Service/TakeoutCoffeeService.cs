namespace Decorator.Service;

public class TakeoutCoffeeService : ITakeoutCoffeeService
{
    public string GetTakeoutCup()
    {
        return "its a takeout coffee";
    }
}
