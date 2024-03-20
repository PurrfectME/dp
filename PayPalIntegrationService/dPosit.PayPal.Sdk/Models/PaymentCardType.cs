namespace dPosit.PayPal.Sdk.Models;

public enum PaymentCardType
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// A credit card.
    /// </summary>
    Credit,
    /// <summary>
    /// A debit card.
    /// </summary>
    Debit,
    /// <summary>
    /// A Prepaid card.
    /// </summary>
    Prepaid,
    /// <summary>
    /// Card type cannot be determined.
    /// </summary>
    Unknown
}
