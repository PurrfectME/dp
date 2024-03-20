using System.Text.Json.Serialization;

namespace dPosit.PayPal.Sdk.Api.Models;

internal sealed class PaymentMethod
{
    /// <summary>
    /// The merchant-preferred payment methods.
    /// </summary>
    /// <value>
    /// "UNRESTRICTED" - accepts any type of payment from the customer.<br/>
    /// "IMMEDIATE_PAYMENT_REQUIRED" - accepts only immediate payment from the customer. For example, credit card, PayPal balance, or
    /// instant ACH. Ensures that at the time of capture, the payment does not have the `pending` status.
    /// </value>
    [JsonPropertyName("payee_preferred")]
    public string PayeePreferred { get; set; }

    /// <summary>
    /// NACHA (the regulatory body governing the ACH network) requires that API callers (merchants, partners) obtain the consumer’s
    /// explicit authorization before initiating a transaction. To stay compliant, you’ll need to make sure that you retain a compliant
    /// authorization for each transaction that you originate to the ACH Network using this API. ACH transactions are categorized
    /// (using SEC codes) by how you capture authorization from the Receiver (the person whose bank account is being debited or credited).
    /// </summary>
    /// <value>
    /// "TEL" - the API caller (merchant/partner) accepts authorization and payment information from a consumer over the telephone.<br/>
    /// "WEB" - the API caller (merchant/partner) accepts Debit transactions from a consumer on their website.<br/>
    /// "CCD" - cash concentration and disbursement for corporate debit transaction. Used to disburse or consolidate funds. Entries are
    /// usually Optional high-dollar, low-volume, and time-critical. (e.g. intra-company transfers or invoice payments to suppliers).<br/>
    /// "PPD" - prearranged payment and deposit entries. Used for debit payments authorized by a consumer account holder, and usually
    /// initiated by a company. These are usually recurring debits (such as insurance premiums).
    /// </value>
    [JsonPropertyName("standard_entry_class_code")]
    public string StandardEntryClassCode { get; set; }
}
