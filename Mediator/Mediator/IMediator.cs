using System;

namespace Mediator.Mediator;

public interface IMediator
{
    void Notify(object sender, string ev);
}
