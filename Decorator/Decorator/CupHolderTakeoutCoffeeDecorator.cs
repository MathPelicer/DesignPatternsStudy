using Decorator.Decorator;
using Decorator.Service;

namespace Decorator;

public class CupHolderTakeoutCoffeeDecorator : TakeoutCoffeeDecorator
{
    public CupHolderTakeoutCoffeeDecorator(ITakeoutCoffeeService takeoutCoffeeService) : base(takeoutCoffeeService)
    {
    }

    public override string GetTakeoutCup()
    {
        return base.GetTakeoutCup() + " with a cup holder to take it home";
    }
}
