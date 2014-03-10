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
            _bus.Send(command);
        }

        public GetAllCustomersResponse SendQuery(GetAllCustomersQuery query)
        {
            return _bus.Send(query);
        }
    }
}