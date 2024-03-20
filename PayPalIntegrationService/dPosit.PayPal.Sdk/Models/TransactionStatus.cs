namespace dPosit.PayPal.Sdk.Models;

public enum TransactionStatus
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// PayPal or merchant rules denied the transaction.
    /// </summary>
    D,
    /// <summary>
    /// The transaction is pending. The transaction was created but waits for another payment process to complete, such as an ACH
    /// transaction, before the status changes to S.
    /// </summary>
    P,
    /// <summary>
    /// The transaction successfully completed without a denial and after any pending statuses.
    /// </summary>
    S,
    /// <summary>
    /// A successful transaction was reversed and funds were refunded to the original sender.
    /// </summary>
    V
}
