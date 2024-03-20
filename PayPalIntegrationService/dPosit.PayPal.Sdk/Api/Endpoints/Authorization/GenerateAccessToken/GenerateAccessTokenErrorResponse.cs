using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;

internal sealed class GenerateAccessTokenErrorResponse : ErrorResponse
{
    [JsonPropertyName("supported_authn_schemes")]
    public string[] SupportedAuthnSchemes { get; set; }
}
