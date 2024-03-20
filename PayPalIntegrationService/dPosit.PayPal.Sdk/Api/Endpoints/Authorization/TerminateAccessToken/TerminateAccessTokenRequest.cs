namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.TerminateAccessToken;

internal sealed class TerminateAccessTokenRequest : AuthorizedRequest
{
    /// <summary>
    /// The token to get revoked.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// A hint about the type of the token submitted for revocation. Optional.
    /// </summary>
    /// <value>
    /// "ACCESS_TOKEN" - to terminate access token.<br/>
    /// "REFRESH_TOKEN" - to terminate refresh token.
    /// </value>
    public string TokenTypeHint { get; set; }

    /// <summary>
    /// Type of credentials for authorization to initiate token termination.
    /// </summary>
    /// <value>
    /// "client_credentials" - use credentials to get access token.<br/>
    /// "refresh_token" - use refresh token to get access token.<br/>
    /// "authorization_code" use authorization code to get access token.
    /// </value>
    public string GrantType { get; set; }

    /// <summary>
    /// Authorization only for calls with a `grant_type` of `authorization_code`.
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// Authorization only for calls with a `grant_type` of `refresh_token`.
    /// </summary>
    public string Code { get; set; }

    public IEnumerable<KeyValuePair<string, string>> ToKeyValuePairCollection()
    {
        if (Token != null)
        {
            yield return new KeyValuePair<string, string>("token", Token);
        }

        if (TokenTypeHint != null)
        {
            yield return new KeyValuePair<string, string>("token_type_hint", TokenTypeHint);
        }

        if (GrantType != null)
        {
            yield return new KeyValuePair<string, string>("grant_type", GrantType);
        }

        if (RefreshToken != null)
        {
            yield return new KeyValuePair<string, string>("refresh_token", RefreshToken);
        }

        if (Code != null)
        {
            yield return new KeyValuePair<string, string>("code", Code);
        }
    }
}
