using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateClientToken;

internal sealed class GenerateClientTokenRequest : AuthorizedRequest
{
    /// <summary>
    /// The customer-specific id associated with the client token.
    /// </summary>
    [JsonPropertyName("customer_id")]
    public string CustomerId { get; set; }
}
