namespace Builder;

public class CoffeeService : ICoffeeService
{
    private readonly IEspressoBasedDrinkBuilder _espressoBuilder;

    public CoffeeService(IEspressoBasedDrinkBuilder espressoBuilder)
    {
        _espressoBuilder = espressoBuilder;
    }

    public void GetSomeCoffee()
    {
        EspressoBasedDrinkDirector coffeeDirector = new(_espressoBuilder);

        coffeeDirector.BuildSimpleEspresso();

        Console.WriteLine("Making a simple espresso");
        Console.WriteLine(_espressoBuilder.GetCoffee().ToString());
        Console.WriteLine();

        coffeeDirector.BuildCapuccino();

        Console.WriteLine("Making a capuccino");
        Console.WriteLine(_espressoBuilder.GetCoffee().ToString());
        Console.WriteLine();

        coffeeDirector.BuildAffogato();

        Console.WriteLine("Making a Affogato");
        Console.WriteLine(_espressoBuilder.GetCoffee().ToString());
        Console.WriteLine();
    }
}
