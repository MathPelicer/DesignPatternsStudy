namespace Mediator.Components;

public class DrinksComponent : BaseComponent
{
    public void MakeExpresso()
    {
        Console.WriteLine("Making a shot of expresso");
        this._mediator.Notify(this, "pay");
    }
}
