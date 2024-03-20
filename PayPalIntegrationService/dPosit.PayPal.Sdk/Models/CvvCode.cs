namespace dPosit.PayPal.Sdk.Models;

public enum CvvCode
{
    /// <summary>
    /// Default empty value
    /// </summary>
    None,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, error - unrecognized or unknown response.
    ///</summary>
    E,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, invalid or null.
    ///</summary>
    I,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, the CVV2/CSC matches.
    ///</summary>
    M,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, the CVV2/CSC does not match.
    ///</summary>
    N,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, it was not processed.
    ///</summary>
    P,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, the service is not supported.
    ///</summary>
    S,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, unknown - the issuer is not certified.
    ///</summary>
    U,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, no response. For Maestro, the service is not available.
    ///</summary>
    X,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, error.
    ///</summary>
    AllOthers,
    /// <summary>
    /// For Maestro, the CVV2 matched.
    ///</summary>
    Zero,
    /// <summary>
    /// For Maestro, the CVV2 did not match.
    ///</summary>
    One,
    /// <summary>
    /// For Maestro, the merchant has not implemented CVV2 code handling.
    ///</summary>
    Two,
    /// <summary>
    /// For Maestro, the merchant has indicated that CVV2 is not present on card.
    ///</summary>
    Three,
    /// <summary>
    /// For Maestro, the service is not available.
    /// </summary>
    Four
}
