using System;
using System.Threading.Tasks;

namespace LightBus.Example.Wcf.Server
{
    public class LoggingHandler : IHandleMessages<IMessage>
    {
        public async Task HandleAsync(IMessage message)
        {
            await Task.Delay(20);
            Console.WriteLine("{0} was handled", message.GetType().Name);
        }
    }
}