using System;
using Mediator.Mediator;

namespace Mediator.Components;

public class BaseComponent(IMediator mediator = null)
{
    protected IMediator _mediator = mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}
