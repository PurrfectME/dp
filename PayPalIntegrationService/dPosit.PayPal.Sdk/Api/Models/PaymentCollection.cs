using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PaymentCollection
{
    /// <summary>
    /// An array of authorized payments for a purchase unit. A purchase unit can have zero or more authorized payments.
    /// </summary>
    [JsonPropertyName("authorizations")]
    public AuthorizationWithAdditionalData[] Authorizations { get; set; }

    /// <summary>
    /// An array of captured payments for a purchase unit. A purchase unit can have zero or more captured payments.
    /// </summary>
    [JsonPropertyName("captures")]
    public Capture[] Captures { get; set; }

    /// <summary>
    /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
    /// </summary>
    [JsonPropertyName("refunds")]
    public Refund[] Refunds { get; set; }
}
