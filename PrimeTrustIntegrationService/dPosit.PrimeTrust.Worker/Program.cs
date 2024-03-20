using dPosit.PrimeTrust.Worker;
using dPosit.PrimeTrust.Worker.Consumers;
using MassTransit;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(
        (hostContext, services) =>
        {
            services.AddMassTransit(
                serviceCollectionConfigurator =>
                {
                    serviceCollectionConfigurator.AddConsumer<PrimeTrustWebHookConsumer>();

                    serviceCollectionConfigurator.UsingAzureServiceBus(
                        (context, cfg) =>
                        {
                            cfg.Host(hostContext.Configuration.GetConnectionString("AzureServiceBus"));

                            cfg.ReceiveEndpoint("prime-trust-webhook",
                                endpointConfigurator =>
                                {
                                    endpointConfigurator.AutoStart = true;
                                    endpointConfigurator.ConfigureConsumeTopology = false;
                                    endpointConfigurator.Consumer<PrimeTrustWebHookConsumer>();
                                });
                        });
                });

        })
    .Build();

await host.RunAsync();
