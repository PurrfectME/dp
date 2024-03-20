using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class AuthenticationResponse
{
    /// <summary>
    /// Liability shift indicator. The outcome of the issuer's authentication.
    /// </summary>
    /// <value>
    /// "YES" - liability has shifted to the card issuer. Available only after order is authorized or captured.<br/>
    /// "NO" - liability is with the merchant.<br/>
    /// "POSSIBLE" - liability may shift to the card issuer. Available only before order is authorized or captured.<br/>
    /// "UNKNOWN" - the authentication system is not available.
    /// </value>
    [JsonPropertyName("liability_shift")]
    public string LiabilityShift { get; set; }

    /// <summary>
    /// Results of 3D Secure Authentication.
    /// </summary>
    [JsonPropertyName("three_d_secure")]
    public ThreeDSecureAuthenticationResponse ThreeDSecure { get; set; }
}
