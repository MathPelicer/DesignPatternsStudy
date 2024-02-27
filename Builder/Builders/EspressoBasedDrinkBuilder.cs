namespace Builder;

public class EspressoBasedDrinkBuilder : IEspressoBasedDrinkBuilder
{
    private EspressoBasedDrink espressoBasedDrink = new();

    public EspressoBasedDrinkBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        espressoBasedDrink = new EspressoBasedDrink();
    }

    public void SetChocolate(int chocolateVolume)
    {
        espressoBasedDrink.Chocolate = chocolateVolume;
    }

    public void SetCoffee(int coffeeVolume)
    {
        espressoBasedDrink.Coffee = coffeeVolume;
    }

    public void SetFoamedMilk(int foamedMilkVolume)
    {
        espressoBasedDrink.FoamedMilk = foamedMilkVolume;
    }

    public void SetSteamedMilk(int steamedMilkVolume)
    {
        espressoBasedDrink.SteamedMilk = steamedMilkVolume;
    }

    public void SetVanillaIceCream()
    {
        espressoBasedDrink.HasVanillaIceCream = true;
    }

    public void SetWater(int waterVolume)
    {
        espressoBasedDrink.Water = waterVolume;
    }

    public EspressoBasedDrink GetCoffee()
    {
        var result = espressoBasedDrink;

        Reset();

        return result;
    }
}
