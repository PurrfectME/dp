using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PaymentSource
{
    /// <summary>
    /// The tokenized payment source to fund a payment.
    /// </summary>
    [JsonPropertyName("token")]
    public Token Token { get; set; }
}
