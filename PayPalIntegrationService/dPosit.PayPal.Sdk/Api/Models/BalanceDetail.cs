using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class BalanceDetail
{
    /// <summary>
    /// Currency Code of the balances listed.
    /// </summary>
    /// <value>
    /// The three-character ISO-4217 currency code that identifies the currency.
    /// </value>
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The total amount in PayPal account. It is the sum of all the other balances.
    /// </summary>
    [JsonPropertyName("total_balance")]
    public Money TotalBalance { get; set; }

    /// <summary>
    /// The amount of cash in an Account which is at the customer's disposal. This amount is captured at settlement cutoff time in the
    /// user's time zone as defined for the user.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public Money AvailableBalance { get; set; }

    /// <summary>
    /// Optional field representing if the currency is primary currency or not.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// Balance withheld in the account. The portion of funds that PayPal holds for the customer that is not currently at the customer's
    /// disposal.
    /// </summary>
    [JsonPropertyName("withheld_balance")]
    public Money WithheldBalance { get; set; }
}
