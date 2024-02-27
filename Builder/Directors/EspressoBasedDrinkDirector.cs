namespace Builder;

public class EspressoBasedDrinkDirector
{
    private IEspressoBasedDrinkBuilder _espressoBuilder;

    public EspressoBasedDrinkDirector(IEspressoBasedDrinkBuilder espressoBuilder)
    {
        _espressoBuilder = espressoBuilder;
    }

    public void BuildSimpleEspresso()
    {
        _espressoBuilder.SetCoffee(30);
    }

    public void BuildDoppio()
    {
        _espressoBuilder.SetCoffee(60);
    }

    public void BuildLungo()
    {
        _espressoBuilder.SetCoffee(90);
    }

    public void BuildAffogato()
    {
        _espressoBuilder.SetCoffee(60);
        _espressoBuilder.SetVanillaIceCream();
    }

    public void BuildCapuccino()
    {
        _espressoBuilder.SetCoffee(60);
        _espressoBuilder.SetFoamedMilk(60);
        _espressoBuilder.SetSteamedMilk(60);
    }
}
