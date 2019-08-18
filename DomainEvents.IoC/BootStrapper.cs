using DomainEvents.Domain.Events;
using DomainEvents.Domain.Handlers;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEvents.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            #region Events

            container.RegisterCollection(typeof(IHandler<>), typeof(IDomainEvent).Assembly);

            #endregion
        }

        public static void Raise<TEventEntity>(Container container, TEventEntity eventEntity) where TEventEntity : IDomainEvent
        {
            var handles = container.GetAllInstances<IHandler<TEventEntity>>();
            foreach (var handle in handles)
            {
                handle.Handler(eventEntity);
            }
        }
    }
}
