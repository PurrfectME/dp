using dPosit.PayPal.Sdk.Api.Endpoints.Authorization.GenerateAccessToken;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Extensions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.RequestModels.Authorization;

public sealed class GenerateAccessTokenRequestDto
{
    /// <summary>
    /// The credential type to exchange for an access token.
    /// </summary>
    /// <value>
    /// <c>GrantType.ClientCredentials</c> - use credentials to get access token.<br/>
    /// <c>GrantType.RefreshToken</c> - use refresh token to get access token.<br/>
    /// <c>GrantType.AuthorizationCode</c> - use authorization code to get access token.
    /// </value>
    public GrantType GrantType { get; set; }

    /// <summary>
    /// The refresh token to get access token for call with <c>GrantType.RefreshToken</c>
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// The authorization code to get access token for call with <c>GrantType.AuthorizationCode</c>
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// A new token is issued ignoring the previously issued and still not expired token.
    /// </summary>
    public bool? IgnoreCache { get; set; }

    /// <summary>
    /// Lists user authentication options and returns a first-party access token to authenticate an end user.
    /// </summary>
    /// <remarks>
    /// Valid for all grant types except the <c>GrantType.AuthorizationCode</c>, which indicates that the user is already authenticated.
    /// </remarks>
    public bool? ReturnAuthnSchemes { get; set; }

    /// <summary>
    /// Lists client metadata attributes.
    /// </summary>
    public bool? ReturnClientMetadata { get; set; }

    /// <summary>
    /// Lists unconsented scopes between the user and client. Valid for all grant types except <c>GrantType.ClientCredentials</c>.
    /// </summary>
    public bool? ReturnUnconsentedScopes { get; set; }

    /// <summary>
    /// The redirection endpoint that terminates the user authorization flow. The value must be an EXACT match to the URI registered for
    /// the client during the client registration. If you pass the <see cref="TargetClientId"/> parameter, the URI must be
    /// <see cref="TargetClientId"/>. The out-of-band value is `urn:ietf:wg:oauth:2.0:oob`. Native apps can use the `redirect_uri` parameter.
    /// </summary>
    public string RedirectUri { get; set; }

    /// <summary>
    /// A list of token types.
    /// </summary>
    public ResponseType[] ResponseType { get; set; }

    /// <summary>
    /// The client-specific key-and-value pairs associated with the access token. You can retrieve these pairs through the security context.
    /// </summary>
    public Dictionary<string, string> Claims { get; set; }

    /// <summary>
    /// A list of case-sensitive scopes, or permissions, to associate with the access token. If you omit this value,
    /// the API assumes the maximum set of allowed scopes. The scopes must be one of these values:<br/>
    ///   - a subset of the scopes authorized for the client;<br/>
    ///   - consented by the user in case of end-user scopes;<br/>
    ///   - associated with the refresh token, depending on the `grant_type`.
    /// </summary>
    public string[] Scope { get; set; }

    /// <summary>
    /// The key-and-value pair that defines device information.
    /// </summary>
    public KeyValuePair<string, string> DeviceInfo { get; set; }

    /// <summary>
    /// The key-and-value pair that defines application information.
    /// </summary>
    public KeyValuePair<string, string> AppInfo { get; set; }

    /// <summary>
    /// The key-and-value pairs of data required by risk.
    /// </summary>
    /// <remarks>Required for public clients.</remarks>
    public Dictionary<string, string> RiskData { get; set; }

    /// <summary>
    /// The email address or payer ID of the user for whom you want to create an access token.
    /// </summary>
    public string TargetSubject { get; set; }

    /// <summary>
    /// The client ID of the client application for which the access token is created.
    /// </summary>
    public string TargetClientId { get; set; }

    /// <summary>
    /// The ID of the partner with permission granted by the merchant for the partner to create the access token.
    /// </summary>
    public string PartnerClientId { get; set; }

    private void Validate()
    {
        switch (GrantType)
        {
            case GrantType.None:
                throw new PayPalModelValidationException<GenerateAccessTokenRequestDto>("Missing GrantType.");
            case GrantType.ClientCredentials:
                if (ReturnUnconsentedScopes is not null && ReturnUnconsentedScopes is true)
                {
                    throw new PayPalModelValidationException<GenerateAccessTokenRequestDto>(
                        "Can not use ReturnUnconsentedScopes for GrantType.ClientCredentials.");
                }
                break;
            case GrantType.RefreshToken:
                if (string.IsNullOrWhiteSpace(RefreshToken))
                {
                    throw new PayPalModelValidationException<GenerateAccessTokenRequestDto>(
                        "Missing RefreshToken for GrantType.RefreshToken.");
                }
                break;
            case GrantType.AuthorizationCode:
                if (string.IsNullOrWhiteSpace(Code))
                {
                    throw new PayPalModelValidationException<GenerateAccessTokenRequestDto>(
                        "Missing Code for GrantType.AuthorizationCode.");
                }
                if (ReturnAuthnSchemes is not null && ReturnAuthnSchemes is true)
                {
                    throw new PayPalModelValidationException<GenerateAccessTokenRequestDto>(
                        "Can not use ReturnAuthnSchemes for GrantType.AuthorizationCode.");
                }
                break;
        }

        if (ResponseType is not null && ResponseType.Length > 1)
        {
            if (ResponseType.Contains(Models.ResponseType.None) || ResponseType.Contains(Models.ResponseType.Uat))
            {
                throw new PayPalModelValidationException<GenerateAccessTokenRequestDto>("Incorrect ResponseType.");
            }
        }
    }

    internal GenerateAccessTokenRequest ToRequestModel()
    {
        Validate();

        var claimStrings = Helpers.ConvertToStringEnumerable(Claims).ToArray();
        var riskDataStrings = Helpers.ConvertToStringEnumerable(RiskData).ToArray();
        var responseTypeStrings = ConvertToStringEnumerable(ResponseType).ToArray();

        return new GenerateAccessTokenRequest
        {
            GrantType = GrantType.GetStringValue(),
            RefreshToken = RefreshToken,
            Code = Code,
            IgnoreCache = IgnoreCache,
            ReturnAuthnSchemes = ReturnAuthnSchemes,
            ReturnClientMetadata = ReturnClientMetadata,
            ReturnUnconsentedScopes = ReturnUnconsentedScopes,
            RedirectUri = RedirectUri,
            ResponseType = responseTypeStrings.Length > 0 ? string.Join(' ', responseTypeStrings) : null,
            Claims = claimStrings.Length > 0 ? string.Join(',', claimStrings) : null,
            Scope = Scope?.Length > 0 ? string.Join(' ', Scope) : null,
            DeviceInfo = $"{DeviceInfo.Key}:{DeviceInfo.Value}",
            AppInfo = $"{AppInfo.Key}:{AppInfo.Value}",
            RiskData = riskDataStrings.Length > 0 ? string.Join(',', riskDataStrings) : null,
            TargetSubject = TargetSubject,
            TargetClientId = TargetClientId,
            PartnerClientId = PartnerClientId
        };
    }

    private IEnumerable<string> ConvertToStringEnumerable(ResponseType[] responseTypes)
    {
        return responseTypes?
            .Where(responseType => responseType != Models.ResponseType.None)
            .Select(responseType => responseType.GetStringValue())
               ?? Enumerable.Empty<string>();
    }
}
