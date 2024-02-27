// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;

Console.WriteLine("The fancy coffeeshop offers:");

ClientMethod(new FancyCoffeeShop());
Console.WriteLine();

Console.WriteLine("While the cozy one...");
ClientMethod(new CozyCoffeeShop());

void ClientMethod(IAbstractFactory factory)
{
    var coffee = factory.CreateCoffee();
    var milkyDrink = factory.CreateMilkyDrink();

    Console.WriteLine($"{milkyDrink.GetType()} | {coffee.GetTaste()}");
    Console.WriteLine(milkyDrink.GetCaffeinatedDrink(coffee));
}
