using Mediator.Components;
using Mediator.Mediator;

DrinksComponent expressoComponent = new();
CashierComponent milkComponent = new();
new ConcreteMediator(expressoComponent, milkComponent);

expressoComponent.MakeExpresso();
