namespace dPosit.PayPal.Sdk.Models;

public enum SecCode
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The API caller (merchant/partner) accepts authorization and payment information from a consumer over the telephone.
    /// </summary>
    Tel,
    /// <summary>
    /// The API caller (merchant/partner) accepts Debit transactions from a consumer on their website.
    /// </summary>
    Web,
    /// <summary>
    /// Cash concentration and disbursement for corporate debit transaction. Used to disburse or consolidate funds. Entries are
    /// usually Optional high-dollar, low-volume, and time-critical. (e.g. intra-company transfers or invoice payments to suppliers).
    /// </summary>
    Ccd,
    /// <summary>
    /// Prearranged payment and deposit entries. Used for debit payments authorized by a consumer account holder, and usually
    /// initiated by a company. These are usually recurring debits (such as insurance premiums).
    /// </summary>
    Ppd
}
