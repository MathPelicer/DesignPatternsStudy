// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;

Console.WriteLine("The first coffee shop offers:");

ClientMethod(new CoffeeShop1Factory());
Console.WriteLine();

Console.WriteLine("While the second one...");
ClientMethod(new CoffeeShop2Factory());

void ClientMethod(IAbstractFactory factory)
{
    var coffee = factory.CreateCoffee();
    var tea = factory.CreateTea();

    Console.WriteLine($"{tea.GetType()} | {coffee.GetTaste()}");
    Console.WriteLine(tea.GetcaffeinatedTea(coffee));
}
