using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class CustomerService : ICustomerService
    {
        private readonly IBus _bus;

        public CustomerService(IBus bus)
        {
            _bus = bus;
        }

        public void SendCommand(CreateCustomerCommand command)
        {
            _bus.SendAsync(command).Wait();
        }

        public GetAllCustomersResponse SendQuery(GetAllCustomersQuery query)
        {
            return _bus.SendAsync(query).Result;
        }
    }
}