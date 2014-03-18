using System;
using System.Threading.Tasks;
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

        public Task HandleAsync(CreateCustomerCommand command)
        {
            Console.WriteLine("Creating customer {0}.", command.Name);
            var customerId = Guid.NewGuid();
            Db.Customers.Add(new Customer { Id = customerId, Name = command.Name });
            return _bus.PublishAsync(new CustomerCreatedEvent { CustomerId = customerId });
        }
    }
}