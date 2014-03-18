using System;
using System.Threading.Tasks;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class CustomerCreatedHandler : IHandleMessages<CustomerCreatedEvent>
    {
        public async Task HandleAsync(CustomerCreatedEvent command)
        {
            await Task.Delay(50);
            Console.WriteLine("Customer with id {0} created.", command.CustomerId);
        }
    }
}