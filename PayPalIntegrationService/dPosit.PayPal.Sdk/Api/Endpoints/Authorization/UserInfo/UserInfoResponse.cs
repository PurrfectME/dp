using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.UserInfo;

internal sealed class UserInfoResponse
{
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("sub")]
    public string Sub { get; set; }
}
