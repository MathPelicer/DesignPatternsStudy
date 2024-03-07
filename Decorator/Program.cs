using Decorator;
using Decorator.Decorator;
using Decorator.Service;

ITakeoutCoffeeService takeoutCoffee = new TakeoutCoffeeService();
ITakeoutCoffeeService hotTakeout = new HotTakeoutCoffeeDecorator(takeoutCoffee);

Console.WriteLine(hotTakeout.GetTakeoutCup());

ITakeoutCoffeeService cupHolderTakeout = new CupHolderTakeoutCoffeeDecorator(takeoutCoffee);

Console.WriteLine(cupHolderTakeout.GetTakeoutCup());

ITakeoutCoffeeService cupHolderAndHandleTakeout = new CupHolderTakeoutCoffeeDecorator(hotTakeout);

Console.WriteLine(cupHolderAndHandleTakeout.GetTakeoutCup());
