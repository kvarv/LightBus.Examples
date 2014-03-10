using System;
using System.Collections.Generic;
using System.ServiceModel;
using LightBus.Example.Wcf.Contracts;

namespace LightBus.Example.Wcf.Client
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "WCF Client";

            var service = GetService<ICustomerService>("http://localhost:8080/customerservice");

            Console.WriteLine("Type a name and press 'Enter' to create a customer. To exit, press 'q' and then 'Enter'.");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "q")
                    break;
                var order = new CreateCustomerCommand {Name = input};
                service.SendCommand(order);

                var getAllCustomersResponse = service.SendQuery(new GetAllCustomersQuery());

                Console.WriteLine("All customers:");
                PrintCustomers(getAllCustomersResponse.Cutomers);
            }
        }

        private static void PrintCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1}", customer.Id, customer.Name);
            }
        }

        private static T GetService<T>(string endpointAddress)
        {
            var cf = new ChannelFactory<T>(new BasicHttpBinding(), new EndpointAddress(endpointAddress));
            return cf.CreateChannel();
        }
    }
}