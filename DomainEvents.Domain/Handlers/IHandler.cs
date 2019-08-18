using DomainEvents.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEvents.Domain.Handlers
{
    public interface IHandler<in TEventEntity> where TEventEntity : IDomainEvent
    {
        void Handler(TEventEntity args);
    }
}
