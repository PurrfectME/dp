using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListAllBalances;

internal sealed class ListAllBalancesResponse
{
    /// <summary>
    /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number
    /// is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// The requested date and time or the last date and time when the balances can be served, in Internet date and time format.
    /// Seconds are required while fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("as_of_time")]
    public string AsOfTime { get; set; }

    /// <summary>
    /// An array of balance detail objects.
    /// </summary>
    [JsonPropertyName("balances")]
    public BalanceDetail[] Balances { get; set; }

    /// <summary>
    /// The date and time when the balances was last refreshed, in Internet date and time format. Seconds are required.
    /// Fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("last_refresh_time")]
    public string LastRefreshTime { get; set; }
}
