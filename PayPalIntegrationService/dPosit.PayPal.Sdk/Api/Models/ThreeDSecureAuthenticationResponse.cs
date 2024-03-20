using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class ThreeDSecureAuthenticationResponse
{
    /// <summary>
    /// The outcome of the issuer's authentication.
    /// </summary>
    /// <value>
    /// "Y" - successful authentication.<br/>
    /// "N" - failed authentication / account not verified / transaction denied.<br/>
    /// "U" - unable to complete authentication.<br/>
    /// "A" - successful attempts transaction.<br/>
    /// "C" - challenge required for authentication.<br/>
    /// "R" - authentication rejected (merchant must not submit for authorization).<br/>
    /// "D" - challenge required; decoupled authentication confirmed.<br/>
    /// "I" - informational only; 3DS requestor challenge preference acknowledged.
    /// </value>
    [JsonPropertyName("authentication_status")]
    public string AuthenticationStatus { get; set; }

    /// <summary>
    /// Status of authentication eligibility.
    /// </summary>
    /// <value>
    /// "Y" - yes. The bank is participating in 3-D Secure protocol and will return the ACSUrl.<br/>
    /// "N" - no. The bank is not participating in 3-D Secure protocol.<br/>
    /// "U" - unavailable. The DS or ACS is not available for authentication at the time of the request.<br/>
    /// "B" - bypass. The merchant authentication rule is triggered to bypass authentication.
    /// </value>
    [JsonPropertyName("enrollment_status")]
    public string EnrollmentStatus { get; set; }
}
