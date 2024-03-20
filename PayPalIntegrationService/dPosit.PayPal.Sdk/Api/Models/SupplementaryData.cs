using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class SupplementaryData
{
    /// <summary>
    /// Identifiers related to a specific resource.
    /// </summary>
    [JsonPropertyName("related_ids")]
    public RelatedIds RelatedIds { get; set; }
}
