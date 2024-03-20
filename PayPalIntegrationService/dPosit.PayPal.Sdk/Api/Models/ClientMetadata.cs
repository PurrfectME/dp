using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ClientMetadata
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("logo_uri")]
    public string LogoUri { get; set; }

    [JsonPropertyName("scopes")]
    public string[] Scopes { get; set; }

    [JsonPropertyName("ui_type")]
    public string UiType { get; set; }
}
