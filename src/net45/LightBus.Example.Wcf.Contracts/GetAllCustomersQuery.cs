using System;
using System.Collections.Generic;

namespace LightBus.Example.Wcf.Contracts
{
    public class GetAllCustomersQuery : IQuery<GetAllCustomersResponse>
    {
    }

    public class GetAllCustomersResponse
    {
        public List<Customer> Cutomers { get; set; }
    }

    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}