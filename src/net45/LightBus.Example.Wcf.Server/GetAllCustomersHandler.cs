using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class GetAllCustomersHandler : IHandleQueries<GetAllCustomersQuery, GetAllCustomersResponse>
    {
        public GetAllCustomersResponse Handle(GetAllCustomersQuery query)
        {
            return new GetAllCustomersResponse
            {
                Cutomers = Db.Customers
            };
        }
    }
}