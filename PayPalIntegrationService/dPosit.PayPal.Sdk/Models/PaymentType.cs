namespace dPosit.PayPal.Sdk.Models;

public enum PaymentType
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// One Time payment such as online purchase or donation. (e.g. Checkout with one-click).
    /// </summary>
    OneTime,
    /// <summary>
    /// Payment which is part of a series of payments with fixed or variable amounts, following a fixed time interval. (e.g. Subscription
    /// payments).
    /// </summary>
    Recurring,
    /// <summary>
    /// Payment which is part of a series of payments that occur on a non-fixed schedule and/or have variable amounts. (e.g.
    /// Account Topup payments).
    /// </summary>
    Unscheduled
}
