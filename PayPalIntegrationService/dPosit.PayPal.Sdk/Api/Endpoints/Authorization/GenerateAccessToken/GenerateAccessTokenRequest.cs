namespace dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;

internal sealed class GenerateAccessTokenRequest
{
    /// <summary>
    /// The credential type to exchange for an access token.
    /// </summary>
    /// <value>
    /// "client_credentials" - use credentials to get access token.<br/>
    /// "refresh_token" - use refresh token to get access token.<br/>
    /// "authorization_code" - use authorization code to get access token.
    /// </value>
    public string GrantType { get; set; }

    /// <summary>
    /// The refresh token. Use to get access tokens. Use the same authorization grant as described in
    /// [OAuth2.0 RFC6749 Section 6](https://tools.ietf.org/html/rfc6749#section-6). Returns value only for `POST /token` calls with a
    /// `grant_type` of `refresh_token`.
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// The authorization code that the `/login` call returns to the client to complete a user log in and get a third-party access token.
    /// Required if the `grant_type` is `authorization_code`.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// A new token is issued ignoring the previously issued and still not expired token.
    /// </summary>
    public bool? IgnoreCache { get; set; }

    /// <summary>
    /// Lists user authentication options and returns a first-party access token to authenticate an end user. Valid for all grant types
    /// except the `authzcode` authorization code, which indicates that the user is already authenticated.
    /// </summary>
    public bool? ReturnAuthnSchemes { get; set; }

    /// <summary>
    /// Lists client metadata attributes. Valid for all grant types.
    /// </summary>
    public bool? ReturnClientMetadata { get; set; }

    /// <summary>
    /// Lists unconsented scopes between the user and client. Valid for all grant types except `client_credentials`.
    /// </summary>
    public bool? ReturnUnconsentedScopes { get; set; }

    /// <summary>
    /// The redirection endpoint that terminates the user authorization flow. The value must be an EXACT match to the URI registered for
    /// the client during the client registration. If you pass the `target_client_id` parameter, the URI must be `target_client_id`.
    /// The out-of-band value is `urn:ietf:wg:oauth:2.0:oob`. Native apps can use the `redirect_uri` parameter.
    /// </summary>
    public string RedirectUri { get; set; }

    /// <summary>
    /// A space-separated list of token types. If the list is valid, the API returns all requested token types.
    /// </summary>
    public string ResponseType { get; set; }

    /// <summary>
    /// The client-specific key-and-value pairs associated with the access token. You can retrieve these pairs through the security context.
    /// Use a comma (`,`) to separate the key-and-value pairs.
    /// </summary>
    public string Claims { get; set; }

    /// <summary>
    /// A list of space-separated and case-sensitive scopes, or permissions, to associate with the access token. If you omit this value,
    /// the API assumes the maximum set of allowed scopes. The scopes must be one of these values:<br/>
    ///   - a subset of the scopes authorized for the client;<br/>
    ///   - consented by the user in case of end-user scopes;<br/>
    ///   - associated with the refresh token, depending on the `grant_type`.
    /// </summary>
    public string Scope { get; set; }

    /// <summary>
    /// The URL-encoded key-and-value pair that defines device information. If `unbind_device` is `true`, you must include the `device_info`
    /// or `refresh_token` parameter.
    /// </summary>
    public string DeviceInfo { get; set; }

    /// <summary>
    /// The URL-encoded key-and-value pair that defines application information. If `unbind_device` is `true`, you must include the
    /// `app_info` or `refresh_token` parameter.
    /// </summary>
    public string AppInfo { get; set; }

    /// <summary>
    /// The URL-encoded key-and-value pairs of data required by risk. You can typically obtain values through the Dyson library.
    /// Required for public clients.
    /// </summary>
    public string RiskData { get; set; }

    /// <summary>
    /// The email address or payer ID of the user for whom you want to create an access token. Required if the `grant_type` is
    /// `client_credentials`, `refresh_token`, or `urn:paypal:params:oauth2:grant_type:unique_device_identifier`.
    /// This kind of `/token` request comes from a legacy client without REST API credentials.
    /// </summary>
    public string TargetSubject { get; set; }

    /// <summary>
    /// The client ID of the client application for which the access token is created. Because the client who makes this kind of `/bind`
    /// request is a proxy, identifies the real client application. The client ID must have the `GRANT_PROXY_CLIENT` scope to use the
    /// `target_client_id` parameter.
    /// </summary>
    public string TargetClientId { get; set; }

    /// <summary>
    /// The ID of the partner with permission granted by the merchant for the partner to create the access token. Required, and only
    /// relevant, if the `grant_type` is set to `client_credentials`, `refresh_token`, or
    /// `urn:paypal:params:oauth2:grant_type:unique_device_identifier
    /// </summary>
    public string PartnerClientId { get; set; }

    // TODO: Naming
    public IEnumerable<KeyValuePair<string, string>> ToKeyValuePairCollection()
    {
        yield return new KeyValuePair<string, string>("ignoreCache", IgnoreCache.ToString());
        yield return new KeyValuePair<string, string>("return_authn_schemes", ReturnAuthnSchemes.ToString());
        yield return new KeyValuePair<string, string>("return_client_metadata", ReturnClientMetadata.ToString());
        yield return new KeyValuePair<string, string>("return_unconsented_scopes", ReturnUnconsentedScopes.ToString());

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

        if (RedirectUri != null)
        {
            yield return new KeyValuePair<string, string>("redirect_uri", RedirectUri);
        }

        if (ResponseType != null)
        {
            yield return new KeyValuePair<string, string>("response_type", ResponseType);
        }

        if (Claims != null)
        {
            yield return new KeyValuePair<string, string>("claims[]", Claims);
        }

        if (Scope != null)
        {
            yield return new KeyValuePair<string, string>("scope", Scope);
        }

        if (DeviceInfo != null)
        {
            yield return new KeyValuePair<string, string>("device_info", DeviceInfo);
        }

        if (AppInfo != null)
        {
            yield return new KeyValuePair<string, string>("app_info", AppInfo);
        }

        if (RiskData != null)
        {
            yield return new KeyValuePair<string, string>("risk_data", RiskData);
        }

        if (TargetSubject != null)
        {
            yield return new KeyValuePair<string, string>("target_subject", TargetSubject);
        }

        if (TargetClientId != null)
        {
            yield return new KeyValuePair<string, string>("target_client_id", TargetClientId);
        }

        if (PartnerClientId != null)
        {
            yield return new KeyValuePair<string, string>("partner_client_id", PartnerClientId);
        }
    }
}
