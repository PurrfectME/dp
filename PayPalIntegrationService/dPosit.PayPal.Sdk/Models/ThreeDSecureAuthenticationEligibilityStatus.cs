namespace dPosit.PayPal.Sdk.Models;

public enum ThreeDSecureAuthenticationEligibilityStatus
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Yes. The bank is participating in 3-D Secure protocol and will return the ACSUrl.
    /// </summary>
    Yes,
    /// <summary>
    /// No. The bank is not participating in 3-D Secure protocol.
    /// </summary>
    No,
    /// <summary>
    /// Unavailable. The DS or ACS is not available for authentication at the time of the request.
    /// </summary>
    Unavailable,
    /// <summary>
    /// Bypass. The merchant authentication rule is triggered to bypass authentication.
    /// </summary>
    Bypass
}
