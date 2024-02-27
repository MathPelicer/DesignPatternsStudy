using Builder;

CoffeeService coffeeService = new(new EspressoBasedDrinkBuilder());

coffeeService.GetSomeCoffee();


