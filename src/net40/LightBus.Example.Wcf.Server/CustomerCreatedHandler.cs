using System;
using System.Threading.Tasks;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class CustomerCreatedHandler : IHandleMessages<CustomerCreatedEvent>
    {
        public Task HandleAsync(CustomerCreatedEvent command)
        {
            return TaskExt.Delay(10).ContinueWith(tsk => Console.WriteLine("Customer with id {0} created.", command.CustomerId));
        }
    }
}