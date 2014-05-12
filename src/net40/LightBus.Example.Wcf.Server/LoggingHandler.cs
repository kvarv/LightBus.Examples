using System;
using System.Threading.Tasks;

namespace LightBus.Example.Wcf.Server
{
    public class LoggingHandler : IHandleMessages<IMessage>
    {
        public Task HandleAsync(IMessage message)
        {
            return TaskExt.Delay(20).ContinueWith(_ => Console.WriteLine("{0} was handled", message.GetType().Name));
        }
    }
}