using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PlatformFee
{
    /// <summary>
    /// The fee for this transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }

    /// <summary>
    /// The recipient of the fee for this transaction. If you omit this value, the default is the API caller.
    /// </summary>
    [JsonPropertyName("payee")]
    public Payee Payee { get; set; }
}
