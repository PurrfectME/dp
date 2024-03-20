using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class StoreInfo
{
    /// <summary>
    /// The ID of a store for a merchant in the system of record.
    /// </summary>
    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    /// <summary>
    /// The terminal ID for the checkout stand in a merchant store.
    /// </summary>
    [JsonPropertyName("terminal_id")]
    public string TerminalId { get; set; }
}
