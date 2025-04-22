namespace State;

public class CoffeeBeanState : State
{
    public override void Grinding()
    {
        Console.WriteLine("Coffee is being grinded");
        _context.TransitionTo(new GrindedCoffeeState());
    }

    public override void Extracting()
    {
        throw new NotImplementedException();
    }
}
