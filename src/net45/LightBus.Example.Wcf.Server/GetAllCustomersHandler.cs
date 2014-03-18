using System.Threading.Tasks;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class GetAllCustomersHandler : IHandleQueries<GetAllCustomersQuery, GetAllCustomersResponse>
    {
        public async Task<GetAllCustomersResponse> HandleAsync(GetAllCustomersQuery query)
        {
            await Task.Delay(50);
            return new GetAllCustomersResponse
            {
                Cutomers = Db.Customers
            };
        }
    }
}