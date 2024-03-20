namespace dPosit.PayPal.Sdk.Models;

public enum AvsCode
{
    /// <summary>
    /// Default empty value
    /// </summary>
    None,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the address matches but the zip code does not match. For American Express
    /// transactions, the card holder address is correct.
    /// </summary>
    A,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the address matches. International A.
    /// </summary>
    B,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, no values match. International N.
    /// </summary>
    C,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the address and postal code match. International X.
    /// </summary>
    D,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, not allowed for Internet or phone transactions. For American Express card
    /// holder, the name is incorrect but the address and postal code match.
    /// </summary>
    E,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the address and postal code match. UK-specific X. For American Express
    /// card holder, the name is incorrect but the address matches.
    /// </summary>
    F,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, global is unavailable. Nothing matches.
    /// </summary>
    G,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, international is unavailable. Not applicable.
    /// </summary>
    I,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the address and postal code match. For American Express card holder, the
    /// name, address, and postal code match.
    /// </summary>
    M,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, nothing matches. For American Express card holder, the address and postal
    /// code are both incorrect.
    /// </summary>
    N,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, postal international Z. Postal code only.
    /// </summary>
    P,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, re-try the request. For American Express, the system is unavailable.
    /// </summary>
    R,
    /// <summary>
    /// For Visa, Mastercard, Discover, or American Express, the service is not supported.
    /// </summary>
    S,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the service is unavailable. For American Express, information is not
    /// available. For Maestro, the address is not checked or the acquirer had no response. The service is not available.
    /// </summary>
    U,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, whole ZIP code. For American Express, the card holder name, address, and
    /// postal code are all incorrect.
    /// </summary>
    W,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, exact match of the address and the nine-digit ZIP code. For American
    /// Express, the card holder name, address, and postal code are all incorrect.
    /// </summary>
    X,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the address and five-digit ZIP code match. For American Express, the
    /// card holder address and postal code are both correct.
    /// </summary>
    Y,
    /// <summary>
    /// For Visa, Mastercard, or Discover transactions, the five-digit ZIP code matches but no address. For American Express,
    /// only the card holder postal code is correct.
    /// </summary>
    Z,
    /// <summary>
    /// For Maestro, no AVS response was obtained.
    /// </summary>
    Null,
    /// <summary>
    /// For Maestro, all address information matches.
    /// </summary>
    Zero,
    /// <summary>
    /// For Maestro, none of the address information matches.
    /// </summary>
    One,
    /// <summary>
    /// For Maestro, part of the address information matches.
    /// </summary>
    Two,
    /// <summary>
    /// For Maestro, the merchant did not provide AVS information. It was not processed.
    /// </summary>
    Three,
    /// <summary>
    /// For Maestro, the address was not checked or the acquirer had no response. The service is not available.
    /// </summary>
    Four
}
