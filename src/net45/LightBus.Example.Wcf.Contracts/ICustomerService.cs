using System.ServiceModel;

namespace LightBus.Example.Wcf.Contracts
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void SendCommand(CreateCustomerCommand command);

        [OperationContract]
        GetAllCustomersResponse SendQuery(GetAllCustomersQuery query);
    }
}