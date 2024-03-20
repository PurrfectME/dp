using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class IncentiveDetail
{
    /// <summary>
    /// The incentive amount.
    /// </summary>
    [JsonPropertyName("incentive_amount")]
    public Money IncentiveAmount { get; set; }

    /// <summary>
    /// The code that identifies an incentive, such as a coupon.
    /// </summary>
    [JsonPropertyName("incentive_code")]
    public string IncentiveCode { get; set; }

    /// <summary>
    /// The incentive program code that identifies a merchant loyalty or incentive program.
    /// </summary>
    [JsonPropertyName("incentive_program_code")]
    public string IncentiveProgramCode { get; set; }

    /// <summary>
    /// The type of incentive, such as a special offer or coupon.
    /// </summary>
    [JsonPropertyName("incentive_type")]
    public string IncentiveType { get; set; }
}
