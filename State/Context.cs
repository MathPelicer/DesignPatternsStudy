namespace State;

public class Context
{
    private State _state = null;

    public Context(State state)
    {
        TransitionTo(state);
    }

    public void TransitionTo(State state)
    {
        Console.WriteLine($"Transitioning to: {state.GetType().Name}");
        _state = state;
        _state.SetContext(this);
    }

    public void GrindCoffeeRequest()
    {
        _state.Grinding();
    }

    public void ExtractCoffeeRequest()
    {
        _state.Extracting();
    }
}
