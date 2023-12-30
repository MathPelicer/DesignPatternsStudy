// See https://refactoring.guru/design-patterns/factory-method for more information
using Factory.Factories;

Console.WriteLine("Using Coffee creator...");
ClientCode(new CoffeeCreator());

Console.WriteLine();

Console.WriteLine("Using Tea creator...");
ClientCode(new TeaCreator());

void ClientCode(AbstractCreator abstractCreator)
{
    Console.WriteLine("I`m not aware of the creator`s class, but still works \n" + abstractCreator.SomeOperation());
}