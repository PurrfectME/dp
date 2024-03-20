using dPosit.Contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace dPosit.Auth.Api.Controllers;

[Microsoft.AspNetCore.Components.Route("api/primeTrust/v2")]
public class WebHookController : ControllerBase
{
    private readonly ISendEndpointProvider _sendEndpointProvider;

    public WebHookController(IBus bus, ISendEndpointProvider sendEndpointProvider)
    {
        _sendEndpointProvider = sendEndpointProvider;
    }

    [HttpPost("webHook")]
    public async Task<IActionResult> Test()
    {
        //will move to other place
        var sendEndpoint =
            await _sendEndpointProvider.GetSendEndpoint(new Uri("sb://dposit-dev.servicebus.windows.net/prime-trust-webhook"));

        await sendEndpoint.Send(
            new PrimeTrustWebHook
            {
                Id = Guid.NewGuid(),
                TimeStamp = DateTimeOffset.Now
            });

        return Ok();
    }
}
