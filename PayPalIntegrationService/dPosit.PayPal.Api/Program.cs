using dPosit.AspNet.Helpers.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddSerilogLogger(
    excludeEndpoints: new[]
    {
        "/health"
    });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks();

builder.Services.AddPayPayHttpClient(options =>
{
    // TODO: Remove hardcoded values. Currently for test purposes only!
    options.Credentials = new()
    {
        ClientId = "AYfHJiD_g83tk55Xk6m7wwiH2M8CRMGM9kn3UrVxFU7J6nz5tcEBL-di7IVfy8Eog-SYhdEuq8jGzsCg",
        Secret = "EDUj-IiZwuY64Q_U7wtKh3HrAHIm-GORD_350UfDWf4hr8V4QE9Xyv79eisuvmh8MEsjXGbzbEzUx0UE"
    };
});

var app = builder.Build();

app.UsePathBase("/paypal-integration");
app.UseRouting();

app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHealthChecks("/health");
});

app.Run();
