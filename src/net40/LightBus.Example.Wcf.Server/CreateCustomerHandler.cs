using System;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class CreateCustomerHandler : IHandleMessages<CreateCustomerCommand>
    {
        private readonly IBus _bus;

        public CreateCustomerHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(CreateCustomerCommand command)
        {
            Console.WriteLine("Creating customer {0}.", command.Name);
            var customerId = Guid.NewGuid();
            Db.Customers.Add(new Customer { Id = customerId, Name = command.Name });
            _bus.Publish(new CustomerCreatedEvent { CustomerId = customerId });
        }
    }
}