namespace dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListTransactions;

internal sealed class ListTransactionsRequest : AuthorizedRequest
{
    /// <summary>
    /// Filters the transactions in the response by a payment instrument type.
    /// </summary>
    /// <value>
    /// "CREDITCARD" - returns a direct credit card transaction with a corresponding value.<br/>
    /// "DEBITCARD" - returns a debit card transaction with a corresponding value.
    /// </value>
    public string PaymentInstrumentType { get; set; }

    /// <summary>
    /// Filters the transactions in the response by an end date and time, in Internet date and time format. Seconds are required.
    /// Fractional seconds are optional. The maximum supported range is 31 days.
    /// </summary>
    public string EndDate { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a start date and time, in Internet date and time format. Seconds are required.
    /// Fractional seconds are optional.
    /// </summary>
    public string StartDate { get; set; }

    /// <summary>
    /// Indicates whether the response includes only balance-impacting transactions or all transactions.
    /// </summary>
    /// <value>
    /// "Y" - the default. The response includes only balance transactions.<br/>
    /// "N" - the response includes all transactions.
    /// </value>
    public string BalanceAffectingRecordsOnly { get; set; }

    /// <summary>
    /// Indicates which fields appear in the response. Value is a single field or a comma-separated list of fields. The
    /// <c>transaction_info</c> value returns only the transaction details in the response. To include all fields in the response,
    /// specify <c>fields=all</c>
    /// </summary>
    /// <value>
    /// "transaction_info" the transaction information. Includes the ID of the PayPal account of the payee, the PayPal-generated
    /// transaction ID, the PayPal-generated base ID, the PayPal reference ID type, the transaction event code, the date and time when
    /// the transaction was initiated and was last updated, the transaction amounts including the PayPal fee, any discounts, insurance,
    /// the transaction status, and other information about the transaction.<br/>
    /// "payer_info" the payer information. Includes the PayPal customer account ID and the payer's email address, primary phone number,
    /// name, country code, address, and whether the payer is verified or unverified.<br/>
    /// "shipping_info" the shipping information. Includes the recipient's name, the shipping method for this order, the shipping address
    /// for this order, and the secondary address associated with this order.<br/>
    /// "auction_info" the auction information. Includes the name of the auction site, the auction site URL, the ID of the customer who
    /// makes the purchase in the auction, and the date and time when the auction closes.<br/>
    /// "cart_info" the cart information. Includes an array of item details, whether the item amount or the shipping amount already
    /// includes tax, and the ID of the invoice for PayPal-generated invoices.<br/>
    /// "incentive_info" an array of incentive detail objects. Each object includes the incentive, such as a special offer or coupon,
    /// the incentive amount, and the incentive program code that identifies a merchant loyalty or incentive program.<br/>
    /// "store_info" the store information. Includes the ID of the merchant store and the terminal ID for the checkout stand in the
    /// merchant store.
    /// </value>
    public string Fields { get; set; }

    /// <summary>
    /// The zero-relative start index of the entire list of items that are returned in the response. So, the combination of <c>page=1</c>
    /// and <c>page_size=20</c> returns the first 20 items.
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// The number of items to return in the response. So, the combination of <c>page=1</c> and <c>page_size=20</c> returns the first
    /// 20 items. The combination of <c>page=2</c> and <c>page_size=20</c> returns the next 20 items.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a store ID.
    /// </summary>
    public string StoreId { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a terminal ID.
    /// </summary>
    public string TerminalId { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a gross transaction amount range. Specify the range as <c>&lt;start-range&gt;</c>
    /// TO <c>&lt;end-range&gt;</c>, where <c>&lt;start-range&gt;</c> is the lower limit of the gross PayPal transaction amount and
    /// <c>&lt;end-range&gt;</c> is the upper limit of the gross transaction amount. Specify the amounts in lower denominations. For
    /// example, to search for transactions from $5.00 to $10.05, specify <c>[500 TO 1005]</c>.
    /// </summary>
    public string TransactionAmount { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a three-character ISO-4217 currency code for the PayPal transaction currency.
    /// </summary>
    public string TransactionCurrency { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a PayPal transaction ID. A valid transaction ID is 17 characters long, except for an
    /// order ID, which is 19 characters long.
    /// </summary>
    /// <remarks>
    /// A transaction ID is not unique in the reporting system. The response can list two transactions with the same ID. One transaction
    /// can be balance affecting while the other is non-balance affecting.
    /// </remarks>
    public string TransactionId { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a PayPal transaction status code.
    /// </summary>
    /// <value>
    /// "D" - PayPal or merchant rules denied the transaction.<br/>
    /// "P" - the transaction is pending. The transaction was created but waits for another payment process to complete, such as an ACH
    /// transaction, before the status changes to S.<br/>
    /// "S" - the transaction successfully completed without a denial and after any pending statuses.<br/>
    /// "V" - a successful transaction was reversed and funds were refunded to the original sender.
    /// </value>
    public string TransactionStatus { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a PayPal transaction event code.
    /// </summary>
    public string TransactionType { get; set; }

    public IDictionary<string, string> ToQueryParams()
    {
        return new Dictionary<string, string>
        {
            { "payment_instrument_type", PaymentInstrumentType },
            { "end_date", EndDate },
            { "start_date", StartDate },
            { "balance_affecting_records_only", BalanceAffectingRecordsOnly },
            { "fields", Fields },
            { "page", Page.ToString() },
            { "page_size", PageSize.ToString() },
            { "store_id", StoreId },
            { "terminal_id", TerminalId },
            { "transaction_amount", TransactionAmount },
            { "transaction_currency", TransactionCurrency },
            { "transaction_id", TransactionId },
            { "transaction_status", TransactionStatus },
            { "transaction_type", TransactionType }
        };
    }
}
