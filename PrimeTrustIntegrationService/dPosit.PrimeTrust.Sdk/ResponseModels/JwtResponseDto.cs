using System.Text.Json.Serialization;

namespace dPosit.PrimeTrust.Sdk.ResponseModels;

public class JwtResponseDto
{
    [JsonPropertyName("token")]
    public string Token { get; set; }
}
