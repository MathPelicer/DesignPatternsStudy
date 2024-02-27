namespace Builder;

public interface IEspressoBasedDrinkBuilder
{
    public void Reset();

    public void SetCoffee(int coffeeVolume);

    public void SetSteamedMilk(int steamedMilkVolume);

    public void SetFoamedMilk(int foamedMilkVolume);

    public void SetChocolate(int chocolateVolume);

    public void SetWater(int waterVolume);

    public void SetVanillaIceCream();

    public EspressoBasedDrink GetCoffee();
}
