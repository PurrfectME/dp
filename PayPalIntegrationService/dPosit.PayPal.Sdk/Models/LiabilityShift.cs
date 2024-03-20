namespace dPosit.PayPal.Sdk.Models;

public enum LiabilityShift
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// Liability has shifted to the card issuer. Available only after order is authorized or captured.
    /// </summary>
    Yes,
    /// <summary>
    /// Liability is with the merchant.
    /// </summary>
    No,
    /// <summary>
    /// Liability may shift to the card issuer. Available only before order is authorized or captured.
    /// </summary>
    Possible,
    /// <summary>
    /// The authentication system is not available.
    /// </summary>
    Unknown
}
