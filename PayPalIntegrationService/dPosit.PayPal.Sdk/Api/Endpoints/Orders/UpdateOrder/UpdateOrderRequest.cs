using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Orders.UpdateOrder;

internal sealed class UpdateOrderRequest : AuthorizedRequest
{
    /// <summary>
    /// An array of JSON patch objects to apply partial updates to resources.
    /// </summary>
    [JsonPropertyName("patch_request")]
    public Patch<object>[] PatchRequest { get; set; } = {};
}
