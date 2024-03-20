namespace dPosit.PayPal.Sdk.Models;

public enum PaypalReferenceIdType
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// An order ID.
    /// </summary>
    Odr,
    /// <summary>
    /// A transaction ID.
    /// </summary>
    Txn,
    /// <summary>
    /// A subscription ID.
    /// </summary>
    Sub,
    /// <summary>
    /// A pre-approved payment ID.
    /// </summary>
    Pap
}
