using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class TransactionInfoDto
{
    /// <summary>
    /// The annual percentage rate (APR). Determines the amount of interest a consumer pays to finance a purchase at a merchant.
    /// </summary>
    /// <value>
    /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as <c>19.99</c>.
    /// </value>
    public string AnnualPercentageRate { get; set; }

    /// <summary>
    /// The available amount of transaction currency during the completion of this transaction.
    /// </summary>
    public MoneyDto AvailableBalance { get; set; }

    /// <summary>
    /// The bank reference ID. The bank provides this value for an ACH transaction.
    /// </summary>
    public string BankReferenceId { get; set; }

    /// <summary>
    /// The overall amount of the credit promotional fee.
    /// </summary>
    public MoneyDto CreditPromotionalFee { get; set; }

    /// <summary>
    /// The credit term. The time span covered by the installment payments as expressed in the term length plus the length time unit code.
    /// </summary>
    public string CreditTerm { get; set; }

    /// <summary>
    /// The overall amount of the credit transaction fee.
    /// </summary>
    public MoneyDto CreditTransactionalFee { get; set; }

    /// <summary>
    /// The merchant-provided custom text.
    /// </summary>
    /// <remarks>
    /// Usually, this field includes the unique ID for payments made with MassPay type transaction.
    /// </remarks>
    public string CustomField { get; set; }

    /// <summary>
    /// The reduction in price offered for goods or services purchased.
    /// </summary>
    /// <remarks>
    /// This discount is for a price reduction that is offered for other than that at a individual item level.
    /// </remarks>
    public MoneyDto DiscountAmount { get; set; }

    /// <summary>
    /// The ending balance.
    /// </summary>
    /// <remarks>
    /// If you specify one or more optional query parameters, the <c>ending_balance</c> response field is empty.
    /// </remarks>
    public MoneyDto EndingBalance { get; set; }

    /// <summary>
    /// The PayPal fee amount. All transaction fees are included in this amount, which is the record of fee associated with the transaction.
    /// </summary>
    /// <remarks>
    /// This field contains a value only when a transaction fee is applied and processed for this transaction.
    /// </remarks>
    public MoneyDto FeeAmount { get; set; }

    /// <summary>
    /// A finer-grained classification of the financial instrument that was used to fund a payment. For example, <c>Visa card</c> or
    /// a <c>Mastercard</c> for a credit card, <c>BANKCARD</c>, <c>DISCOVER</c>, etc. The pattern is not provided because the value is
    /// defined by an external party.
    /// </summary>
    public string InstrumentSubType { get; set; }

    // TODO: Check if possible to use enum.
    /// <summary>
    /// A high-level classification of the type of financial instrument that was used to fund a payment. The pattern is not provided
    /// because the value is defined by an external party. E.g. PAYPAL, CREDIT_CARD, DEBIT_CARD, APPLE_PAY, BANK, VENMO, Pay Upon Invoice,
    /// Pay Later or Alternative Payment Methods (APM).
    /// </summary>
    public string InstrumentType { get; set; }

    /// <summary>
    /// An insurance charge. Guarantees the quality or delivery of a product.
    /// </summary>
    public MoneyDto InsuranceAmount { get; set; }

    /// <summary>
    /// The invoice ID that is sent by the merchant with the transaction.
    /// </summary>
    /// <remarks>
    /// If an invoice ID was sent with the capture request, the value is reported. Otherwise, the invoice ID of the authorizing transaction
    /// is reported.
    /// </remarks>
    public string InvoiceId { get; set; }

    /// <summary>
    /// The special amount that is added to the transaction.
    /// </summary>
    public MoneyDto OtherAmount { get; set; }

    /// <summary>
    /// The payment method that was used for a transaction. Value is <c>PUI</c>, <c>installment</c>, or <c>mEFT</c>.
    /// </summary>
    public PaymentMethodType PaymentMethodType { get; set; }

    /// <summary>
    /// The payment tracking ID, which is a unique ID that partners specify to either get information about a payment or request a refund.
    /// </summary>
    public string PaymentTrackingId { get; set; }

    /// <summary>
    /// The ID of the PayPal account of the counterparty.
    /// </summary>
    public string PaypalAccountId { get; set; }

    /// <summary>
    /// The PayPal-generated base ID. PayPal exclusive. Cannot be altered. Defined as a related, pre-existing transaction or event.
    /// </summary>
    public string PaypalReferenceId { get; set; }

    /// <summary>
    /// The PayPal reference ID type.
    /// </summary>
    public PaypalReferenceIdType PaypalReferenceIdType { get; set; }

    /// <summary>
    /// Indicates whether the transaction is eligible for protection.
    /// </summary>
    public ProtectionEligibility ProtectionEligibility { get; set; }

    /// <summary>
    /// The PayPal- or merchant-reported sales tax amount for the transaction.
    /// </summary>
    public MoneyDto SalesTaxAmount { get; set; }

    /// <summary>
    /// The PayPal- or merchant-reported shipping amount for the transaction.
    /// </summary>
    public MoneyDto ShippingAmount { get; set; }

    /// <summary>
    /// The discount on the shipping amount.
    /// </summary>
    public MoneyDto ShippingDiscountAmount { get; set; }

    /// <summary>
    /// The tax on the shipping service.
    /// </summary>
    public MoneyDto ShippingTaxAmount { get; set; }

    /// <summary>
    /// The tip.
    /// </summary>
    public MoneyDto TipAmount { get; set; }

    /// <summary>
    /// The all-inclusive gross transaction amount that was transferred between the sender and receiver through PayPal.
    /// </summary>
    public MoneyDto TransactionAmount { get; set; }

    /// <summary>
    /// A five-digit transaction event code that classifies the transaction type based on money movement and debit or credit.
    /// </summary>
    public string TransactionEventCode { get; set; }

    /// <summary>
    /// The PayPal-generated transaction ID.
    /// </summary>
    public string TransactionId { get; set; }

    /// <summary>
    /// The date and time when work on a transaction began in the PayPal system, as expressed in the time zone of the account on this side
    /// of the payment. Specify the value in Internet date and time format. Seconds are required while fractional seconds are optional.
    /// </summary>
    public DateTimeOffset TransactionInitiationDate { get; set; }

    /// <summary>
    /// A special note that the payer passes to the payee. Might contain special customer requests, such as shipping instructions.
    /// </summary>
    public string TransactionNote { get; set; }

    /// <summary>
    /// A code that indicates the transaction status.
    /// </summary>
    public TransactionStatus TransactionStatus { get; set; }

    /// <summary>
    /// The subject of payment. The payer passes this value to the payee. The payer controls this data through the interface through which
    /// he or she sends the data.
    /// </summary>
    public string TransactionSubject { get; set; }

    /// <summary>
    /// The date and time when the transaction was last changed, as expressed in the time zone of the account on this side of the payment.
    /// Specify the value in Internet date and time format. Seconds are required while fractional seconds are optional.
    /// </summary>
    public DateTimeOffset TransactionUpdatedDate { get; set; }

    internal static TransactionInfoDto CreateFromModel(TransactionInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new TransactionInfoDto
        {
            AnnualPercentageRate = model.AnnualPercentageRate,
            AvailableBalance = MoneyDto.CreateFromModel(model.AvailableBalance),
            BankReferenceId = model.BankReferenceId,
            CreditPromotionalFee = MoneyDto.CreateFromModel(model.CreditPromotionalFee),
            CreditTerm = model.CreditTerm,
            CreditTransactionalFee = MoneyDto.CreateFromModel(model.CreditTransactionalFee),
            CustomField = model.CustomField,
            DiscountAmount = MoneyDto.CreateFromModel(model.DiscountAmount),
            EndingBalance = MoneyDto.CreateFromModel(model.EndingBalance),
            FeeAmount = MoneyDto.CreateFromModel(model.FeeAmount),
            InstrumentSubType = model.InstrumentSubType,
            InstrumentType = model.InstrumentType,
            InsuranceAmount = MoneyDto.CreateFromModel(model.InsuranceAmount),
            InvoiceId = model.InvoiceId,
            OtherAmount = MoneyDto.CreateFromModel(model.OtherAmount),
            PaymentMethodType = Helpers.ParsePaymentMethodTypeValue(model.PaymentMethodType),
            PaymentTrackingId = model.PaymentTrackingId,
            PaypalAccountId = model.PaypalAccountId,
            PaypalReferenceId = model.PaypalReferenceId,
            PaypalReferenceIdType = Helpers.ParsePaypalReferenceIdTypeValue(model.PaypalReferenceIdType),
            ProtectionEligibility = Helpers.ParseProtectionEligibilityValue(model.ProtectionEligibility),
            SalesTaxAmount = MoneyDto.CreateFromModel(model.SalesTaxAmount),
            ShippingAmount = MoneyDto.CreateFromModel(model.ShippingAmount),
            ShippingDiscountAmount = MoneyDto.CreateFromModel(model.ShippingDiscountAmount),
            ShippingTaxAmount = MoneyDto.CreateFromModel(model.ShippingTaxAmount),
            TipAmount = MoneyDto.CreateFromModel(model.TipAmount),
            TransactionAmount = MoneyDto.CreateFromModel(model.TransactionAmount),
            TransactionEventCode = model.TransactionEventCode,
            TransactionId = model.TransactionId,
            TransactionInitiationDate = DateTimeOffset.Parse(model.TransactionInitiationDate),
            TransactionNote = model.TransactionNote,
            TransactionStatus = Helpers.ParseTransactionStatusValue(model.TransactionStatus),
            TransactionSubject = model.TransactionSubject,
            TransactionUpdatedDate = DateTimeOffset.Parse(model.TransactionUpdatedDate)
        };
    }
}
