namespace Builder;

public class EspressoBasedDrink
{
    public int Coffee { get; set; }

    public int SteamedMilk { get; set; }

    public int FoamedMilk { get; set; }

    public int Chocolate { get; set; }

    public int Water { get; set; }

    public bool HasVanillaIceCream { get; set; }

    public override string ToString()
    {
        return $"""
            Coffee: {Coffee}ml
            SteamedMilk: {SteamedMilk}ml
            FoamedMilk: {FoamedMilk}ml
            Chocolate: {Chocolate}ml
            Water: {Water}ml
            HasVanillaIceCream: {HasVanillaIceCream}
            """;
    }
}
