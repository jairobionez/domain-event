using DomainEvents.Domain.Events;
using System;

namespace DomainEvents.Domain.Handlers
{
    class PersonSave : IHandler<PersonRegisteredEvent>
    {
        public void Handler(PersonRegisteredEvent args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Registro Salvo {args.PersonId}:{args.Name}");
        }
    }
}
