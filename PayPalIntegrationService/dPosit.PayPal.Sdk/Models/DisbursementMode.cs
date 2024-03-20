namespace dPosit.PayPal.Sdk.Models;

public enum DisbursementMode
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The funds are released to the merchant immediately.
    /// </summary>
    Instant,
    /// <summary>
    /// The funds are held for a finite number of days. The actual duration depends on the region and type of integration.
    /// </summary>
    /// <remarks>
    ///  You can release the funds through a referenced payout. Otherwise, the funds disbursed automatically after the specified duration.
    /// </remarks>
    Delayed
}
