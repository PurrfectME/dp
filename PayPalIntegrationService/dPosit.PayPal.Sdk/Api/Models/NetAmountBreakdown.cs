using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class NetAmountBreakdown
{
    /// <summary>
    /// The converted payable amount.
    /// </summary>
    [JsonPropertyName("converted_amount")]
    public Money ConvertedAmount { get; set; }

    /// <summary>
    /// The exchange rate that determines the amount that was debited from the merchant's PayPal account.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public ExchangeRate ExchangeRate { get; set; }

    /// <summary>
    /// The net amount debited from the merchant's PayPal account.
    /// </summary>
    [JsonPropertyName("payable_amount")]
    public Money PayableAmount { get; set; }
}
