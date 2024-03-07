using Decorator.Service;

namespace Decorator.Decorator;

public class HotTakeoutCoffeeDecorator : TakeoutCoffeeDecorator
{
    public HotTakeoutCoffeeDecorator(ITakeoutCoffeeService takeoutCoffeeService) : base(takeoutCoffeeService)
    {
    }

    public override string GetTakeoutCup()
    {
        return base.GetTakeoutCup() + " with a paper handle bc its hot";
    }
}
