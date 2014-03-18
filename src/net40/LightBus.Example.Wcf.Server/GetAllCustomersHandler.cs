using System.Threading.Tasks;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public class GetAllCustomersHandler : IHandleQueries<GetAllCustomersQuery, GetAllCustomersResponse>
    {
        public Task<GetAllCustomersResponse> HandleAsync(GetAllCustomersQuery query)
        {
            return TaskExt.Delay(49).ContinueWith(task => new GetAllCustomersResponse
            {
                Cutomers = Db.Customers
            });
        }
    }
}