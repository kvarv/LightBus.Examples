using System.Collections.Generic;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Server
{
    public static class Db
    {
        private static readonly List<Customer> _customers = new List<Customer>();

        public static List<Customer> Customers
        {
            get { return _customers; }
        }
    }
}