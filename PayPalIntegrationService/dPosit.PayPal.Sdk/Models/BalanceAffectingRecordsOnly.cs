namespace dPosit.PayPal.Sdk.Models;

public enum BalanceAffectingRecordsOnly
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The response includes only balance transactions.
    /// </summary>
    Yes,
    /// <summary>
    /// The response includes all transactions.
    /// </summary>
    No
}
