using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class IncentiveInfo
{
    /// <summary>
    /// An array of incentive details.
    /// </summary>
    [JsonPropertyName("incentive_details")]
    public IncentiveDetail[] IncentiveDetails { get; set; }
}
