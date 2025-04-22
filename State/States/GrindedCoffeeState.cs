using System;

namespace State;

public class GrindedCoffeeState : State
{
    public override void Grinding()
    {
        return;
    }

    public override void Extracting()
    {
        Console.WriteLine("Coffee is being extracted to an expresso");
        _context.TransitionTo(new ExpressoState());
    }
}
