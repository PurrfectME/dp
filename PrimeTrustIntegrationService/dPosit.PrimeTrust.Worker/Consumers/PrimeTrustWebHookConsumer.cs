using dPosit.Contracts;
using MassTransit;

namespace dPosit.PrimeTrust.Worker.Consumers;

public class PrimeTrustWebHookConsumer : IConsumer<PrimeTrustWebHook>
{
    public Task Consume(ConsumeContext<PrimeTrustWebHook> context)
    {
        Thread.Sleep(6000);

        Console.WriteLine(context.Message);

        return Task.CompletedTask;
    }
}
