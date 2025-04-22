using State;

var stateContext = new Context(new CoffeeBeanState());
stateContext.GrindCoffeeRequest();
stateContext.ExtractCoffeeRequest();