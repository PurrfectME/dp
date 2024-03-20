using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class StoredPaymentSource
{
    /// <summary>
    /// The person or party who initiated or triggered the payment.
    /// </summary>
    /// <value>
    /// "CUSTOMER" - payment is initiated with the active engagement of the customer. e.g. a customer checking out on a merchant website.<br/>
    /// "MERCHANT" - payment is initiated by merchant on behalf of the customer without the active engagement of customer. e.g. a merchant
    /// charging the monthly payment of a subscription to the customer.
    /// </value>
    [JsonPropertyName("payment_initiator")]
    public string PaymentInitiator { get; set; }

    /// <summary>
    /// Indicates the type of the stored payment_source payment.
    /// </summary>
    /// <value>
    /// "ONE_TIME" - one Time payment such as online purchase or donation. (e.g. Checkout with one-click).<br/>
    /// "RECURRING" - payment which is part of a series of payments with fixed or variable amounts, following a fixed time interval. (e.g.
    /// Subscription payments).<br/>
    /// "UNSCHEDULED" - payment which is part of a series of payments that occur on a non-fixed schedule and/or have variable amounts. (e.g.
    /// Account Topup payments).
    /// </value>
    [JsonPropertyName("payment_type")]
    public string PaymentType { get; set; }

    /// <summary>
    /// Reference values used by the card network to identify a transaction.
    /// </summary>
    [JsonPropertyName("previous_network_transaction_reference")]
    public NetworkTransactionReference PreviousNetworkTransactionReference { get; set; }

    /// <summary>
    /// Indicates if this is a <c>first</c> or <c>subsequent</c> payment using a stored payment source (also referred to as stored
    /// credential or card on file).
    /// </summary>
    /// <value>
    /// "FIRST" - indicates the Initial/First payment with a payment_source that is intended to be stored upon successful processing of
    /// the payment.<br/>
    /// "SUBSEQUENT" - indicates a payment using a stored payment_source which has been successfully used previously for a payment.<br/>
    /// "DERIVED" - indicates that PayPal will derive the value of `FIRST` or `SUBSEQUENT` based on data available to PayPal.<br/>
    /// </value>
    [JsonPropertyName("usage")]
    public string Usage { get; set; }
}
