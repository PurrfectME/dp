using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class TransactionInfo
{
    /// <summary>
    /// The annual percentage rate (APR). Determines the amount of interest a consumer pays to finance a purchase at a merchant.
    /// </summary>
    /// <value>
    /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as <c>19.99</c>.
    /// </value>
    [JsonPropertyName("annual_percentage_rate")]
    public string AnnualPercentageRate { get; set; }

    /// <summary>
    /// The available amount of transaction currency during the completion of this transaction.
    /// </summary>
    [JsonPropertyName("available_balance")]
    public Money AvailableBalance { get; set; }

    /// <summary>
    /// The bank reference ID. The bank provides this value for an ACH transaction.
    /// </summary>
    [JsonPropertyName("bank_reference_id")]
    public string BankReferenceId { get; set; }

    /// <summary>
    /// The overall amount of the credit promotional fee.
    /// </summary>
    [JsonPropertyName("credit_promotional_fee")]
    public Money CreditPromotionalFee { get; set; }

    /// <summary>
    /// The credit term. The time span covered by the installment payments as expressed in the term length plus the length time unit code.
    /// </summary>
    [JsonPropertyName("credit_term")]
    public string CreditTerm { get; set; }

    /// <summary>
    /// The overall amount of the credit transaction fee.
    /// </summary>
    [JsonPropertyName("credit_transactional_fee")]
    public Money CreditTransactionalFee { get; set; }

    /// <summary>
    /// The merchant-provided custom text.
    /// </summary>
    /// <remarks>
    /// Usually, this field includes the unique ID for payments made with MassPay type transaction.
    /// </remarks>
    [JsonPropertyName("custom_field")]
    public string CustomField { get; set; }

    /// <summary>
    /// The reduction in price offered for goods or services purchased.
    /// </summary>
    /// <remarks>
    /// This discount is for a price reduction that is offered for other than that at a individual item level.
    /// </remarks>
    [JsonPropertyName("discount_amount")]
    public Money DiscountAmount { get; set; }

    /// <summary>
    /// The ending balance.
    /// </summary>
    /// <remarks>
    /// If you specify one or more optional query parameters, the <c>ending_balance</c> response field is empty.
    /// </remarks>
    [JsonPropertyName("ending_balance")]
    public Money EndingBalance { get; set; }

    /// <summary>
    /// The PayPal fee amount. All transaction fees are included in this amount, which is the record of fee associated with the transaction.
    /// </summary>
    /// <remarks>
    /// This field contains a value only when a transaction fee is applied and processed for this transaction.
    /// </remarks>
    [JsonPropertyName("fee_amount")]
    public Money FeeAmount { get; set; }

    /// <summary>
    /// A finer-grained classification of the financial instrument that was used to fund a payment. For example, <c>Visa card</c> or
    /// a <c>Mastercard</c> for a credit card, <c>BANKCARD</c>, <c>DISCOVER</c>, etc. The pattern is not provided because the value is
    /// defined by an external party.
    /// </summary>
    [JsonPropertyName("instrument_sub_type")]
    public string InstrumentSubType { get; set; }

    /// <summary>
    /// A high-level classification of the type of financial instrument that was used to fund a payment. The pattern is not provided
    /// because the value is defined by an external party. E.g. PAYPAL, CREDIT_CARD, DEBIT_CARD, APPLE_PAY, BANK, VENMO, Pay Upon Invoice,
    /// Pay Later or Alternative Payment Methods (APM).
    /// </summary>
    [JsonPropertyName("instrument_type")]
    public string InstrumentType { get; set; }

    /// <summary>
    /// An insurance charge. Guarantees the quality or delivery of a product.
    /// </summary>
    [JsonPropertyName("insurance_amount")]
    public Money InsuranceAmount { get; set; }

    /// <summary>
    /// The invoice ID that is sent by the merchant with the transaction.
    /// </summary>
    /// <remarks>
    /// If an invoice ID was sent with the capture request, the value is reported. Otherwise, the invoice ID of the authorizing transaction
    /// is reported.
    /// </remarks>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// The special amount that is added to the transaction.
    /// </summary>
    [JsonPropertyName("other_amount")]
    public Money OtherAmount { get; set; }

    /// <summary>
    /// The payment method that was used for a transaction. Value is <c>PUI</c>, <c>installment</c>, or <c>mEFT</c>.
    /// </summary>
    /// <remarks>
    /// Appears only for pay upon invoice (PUI), installment, and mEFT transactions. Merchants and partners in the EMEA region can use this
    /// attribute to note transactions that attract turn-over tax.
    /// </remarks>
    [JsonPropertyName("payment_method_type")]
    public string PaymentMethodType { get; set; }

    /// <summary>
    /// The payment tracking ID, which is a unique ID that partners specify to either get information about a payment or request a refund.
    /// </summary>
    [JsonPropertyName("payment_tracking_id")]
    public string PaymentTrackingId { get; set; }

    /// <summary>
    /// The ID of the PayPal account of the counterparty.
    /// </summary>
    [JsonPropertyName("paypal_account_id")]
    public string PaypalAccountId { get; set; }

    /// <summary>
    /// The PayPal-generated base ID. PayPal exclusive. Cannot be altered. Defined as a related, pre-existing transaction or event.
    /// </summary>
    [JsonPropertyName("paypal_reference_id")]
    public string PaypalReferenceId { get; set; }

    /// <summary>
    /// The PayPal reference ID type.
    /// </summary>
    /// <value>
    /// "ODR" - an order ID.<br/>
    /// "TXN" - a transaction ID.<br/>
    /// "SUB" - a subscription ID.<br/>
    /// "PAP" - a pre-approved payment ID.
    /// </value>
    [JsonPropertyName("paypal_reference_id_type")]
    public string PaypalReferenceIdType { get; set; }

    /// <summary>
    /// Indicates whether the transaction is eligible for protection.
    /// </summary>
    /// <value>
    /// "01" - eligible.<br/>
    /// "02" - not eligible.<br/>
    /// "03" - partially eligible.
    /// </value>
    [JsonPropertyName("protection_eligibility")]
    public string ProtectionEligibility { get; set; }

    /// <summary>
    /// The PayPal- or merchant-reported sales tax amount for the transaction.
    /// </summary>
    [JsonPropertyName("sales_tax_amount")]
    public Money SalesTaxAmount { get; set; }

    /// <summary>
    /// The PayPal- or merchant-reported shipping amount for the transaction.
    /// </summary>
    [JsonPropertyName("shipping_amount")]
    public Money ShippingAmount { get; set; }

    /// <summary>
    /// The discount on the shipping amount.
    /// </summary>
    [JsonPropertyName("shipping_discount_amount")]
    public Money ShippingDiscountAmount { get; set; }

    /// <summary>
    /// The tax on the shipping service.
    /// </summary>
    [JsonPropertyName("shipping_tax_amount")]
    public Money ShippingTaxAmount { get; set; }

    /// <summary>
    /// The tip.
    /// </summary>
    [JsonPropertyName("tip_amount")]
    public Money TipAmount { get; set; }

    /// <summary>
    /// The all-inclusive gross transaction amount that was transferred between the sender and receiver through PayPal.
    /// </summary>
    [JsonPropertyName("transaction_amount")]
    public Money TransactionAmount { get; set; }

    /// <summary>
    /// A five-digit transaction event code that classifies the transaction type based on money movement and debit or credit.
    /// </summary>
    [JsonPropertyName("transaction_event_code")]
    public string TransactionEventCode { get; set; }

    /// <summary>
    /// The PayPal-generated transaction ID.
    /// </summary>
    [JsonPropertyName("transaction_id")]
    public string TransactionId { get; set; }

    /// <summary>
    /// The date and time when work on a transaction began in the PayPal system, as expressed in the time zone of the account on this side
    /// of the payment. Specify the value in Internet date and time format. Seconds are required while fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("transaction_initiation_date")]
    public string TransactionInitiationDate { get; set; }

    /// <summary>
    /// A special note that the payer passes to the payee. Might contain special customer requests, such as shipping instructions.
    /// </summary>
    [JsonPropertyName("transaction_note")]
    public string TransactionNote { get; set; }

    /// <summary>
    /// A code that indicates the transaction status.
    /// </summary>
    /// <value>
    /// "D" - PayPal or merchant rules denied the transaction.<br/>
    /// "P" - the transaction is pending. The transaction was created but waits for another payment process to complete, such as an ACH
    /// transaction, before the status changes to S.<br/>
    /// "S" - the transaction successfully completed without a denial and after any pending statuses.<br/>
    /// "V" - a successful transaction was reversed and funds were refunded to the original sender.
    /// </value>
    [JsonPropertyName("transaction_status")]
    public string TransactionStatus { get; set; }

    /// <summary>
    /// The subject of payment. The payer passes this value to the payee. The payer controls this data through the interface through which
    /// he or she sends the data.
    /// </summary>
    [JsonPropertyName("transaction_subject")]
    public string TransactionSubject { get; set; }

    /// <summary>
    /// The date and time when the transaction was last changed, as expressed in the time zone of the account on this side of the payment.
    /// Specify the value in Internet date and time format. Seconds are required while fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("transaction_updated_date")]
    public string TransactionUpdatedDate { get; set; }
}
