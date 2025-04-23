namespace State;

public class CoffeeBeanState : State
{
    public override void Grinding()
    {
        Console.WriteLine("Coffee is being grinded");
        _context.TransitionTo(new GrindedCoffeeState());
        Console.WriteLine("Coffee is now grinded");
    }

    public override void Extracting()
    {
        throw new NotImplementedException();
    }
}
