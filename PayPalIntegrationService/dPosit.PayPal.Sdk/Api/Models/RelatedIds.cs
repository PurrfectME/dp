using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class RelatedIds
{
    /// <summary>
    /// Authorization ID related to the resource.
    /// </summary>
    [JsonPropertyName("authorization_id")]
    public string AuthorizationId { get; set; }

    /// <summary>
    /// Capture ID related to the resource.
    /// </summary>
    [JsonPropertyName("capture_id")]
    public string CaptureId { get; set; }

    /// <summary>
    /// Order ID related to the resource.
    /// </summary>
    [JsonPropertyName("order_id")]
    public string OrderId { get; set; }
}
