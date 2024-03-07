using Decorator.Service;

namespace Decorator.Decorator;

public class TakeoutCoffeeDecorator(ITakeoutCoffeeService takeoutCoffeeService) : ITakeoutCoffeeService
{
    private readonly ITakeoutCoffeeService _takeoutCoffeeService = takeoutCoffeeService;

    public virtual string GetTakeoutCup()
    {
        return _takeoutCoffeeService.GetTakeoutCup();
    }
}
