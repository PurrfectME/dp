﻿using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;

internal sealed class GenerateAccessTokenResponse
{
    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    [JsonPropertyName("app_id")]
    public string AppId { get; set; }

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("supported_authn_schemes")]
    public string[] SupportedAuthnSchemes { get; set; }

    [JsonPropertyName("nonce")]
    public string Nonce { get; set; }

    [JsonPropertyName("client_metadata")]
    public ClientMetadata ClientMetadata { get; set; }
}
