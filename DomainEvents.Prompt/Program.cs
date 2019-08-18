using DomainEvents.Domain.Entities;
using DomainEvents.Domain.Events;
using DomainEvents.IoC;
using SimpleInjector;
using System;

namespace DomainEvents.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência: http://blog.tiagopariz.com/c-ddd-domain-events/

            var container = new Container();
            BootStrapper.RegisterServices(container);

            var person = new Person
            {
                PersonId = new Guid(),
                Name = "Jairo Bionez"
            };

            var save = new PersonRegisteredEvent(person.PersonId, person.Name);

            BootStrapper.Raise(container, save);

            Console.ReadKey();
        }
    }
}
