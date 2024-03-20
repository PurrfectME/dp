using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateClientToken;

internal sealed class GenerateClientTokenResponse
{
    [JsonPropertyName("client_token")]
    public string ClientToken { get; set; }

    [JsonPropertyName("id_token")]
    public string IdToken { get; set; }

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
}
