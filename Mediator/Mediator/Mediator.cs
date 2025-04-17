using System;
using System.Net;
using System.Runtime.CompilerServices;
using Mediator.Components;

namespace Mediator.Mediator;

public class ConcreteMediator : IMediator
{
    private readonly DrinksComponent _drinksComponent;
    private readonly CashierComponent _cashierComponent;

    public ConcreteMediator(DrinksComponent drinksComponent, CashierComponent cashierComponent)
    {
        _drinksComponent = drinksComponent;
        _drinksComponent.SetMediator(this);
        _cashierComponent = cashierComponent;
        _cashierComponent.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        if(ev == "pay")
        {
            System.Console.WriteLine("[go to cashier component]");
            _cashierComponent.PaymentProcedure();
        }
    }
}
