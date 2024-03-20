using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class Token
{
    /// <summary>
    /// The PayPal-generated ID for the token.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The tokenization method that generated the ID.
    /// </summary>
    /// <value>
    /// "BILLING_AGREEMENT" - the PayPal billing agreement ID. References an approved recurring payment for goods or services.
    /// </value>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
