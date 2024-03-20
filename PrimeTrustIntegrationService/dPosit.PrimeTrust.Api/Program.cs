using dPosit.AspNet.Helpers.Extensions;
using dPosit.Contracts;
using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.HttpClients;
using MassTransit;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<IPrimeTrustAccountHttpClient, PrimeTrustAccountHttpClient>();

var azureServiceBus = Bus.Factory.CreateUsingAzureServiceBus(
    cfg =>
    {
        cfg.Host(builder.Configuration.GetConnectionString("AzureServiceBus"));

        cfg.Message<PrimeTrustWebHook>(
            configureTopology =>
            {
                configureTopology.SetEntityName("prime-trust-webhook");
            });
    });

builder.Services.AddMassTransit(
    cfg =>
    {
        cfg.AddBus(provider => azureServiceBus);
    });

builder.Services.AddSingleton<ISendEndpointProvider>(azureServiceBus);
builder.Services.AddSingleton<IBus>(azureServiceBus);

builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks();

builder.Logging.AddSerilogLogger(
    excludeEndpoints: new[]
    {
        "/health"
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHealthChecks("/health");
});

app.Run();
