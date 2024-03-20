using System.Globalization;
using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListTransactions;
using dPosit.PayPal.Sdk.Exceptions;
using dPosit.PayPal.Sdk.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.RequestModels.TransactionSearch;

public sealed class ListTransactionsRequestDto : AuthorizedRequestDto<ListTransactionsRequestDto>
{
    /// <summary>
    /// Filters the transactions in the response by a payment instrument type.
    /// </summary>
    public PaymentInstrumentType PaymentInstrumentType { get; set; }

    /// <summary>
    /// Filters the transactions in the response by an end date and time, in Internet date and time format. Seconds are required.
    /// Fractional seconds are optional. The maximum supported range is 31 days.
    /// </summary>
    public DateTimeOffset? EndDate { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a start date and time, in Internet date and time format. Seconds are required.
    /// Fractional seconds are optional.
    /// </summary>
    public DateTimeOffset? StartDate { get; set; }

    /// <summary>
    /// Indicates whether the response includes only balance-impacting transactions or all transactions.
    /// </summary>
    /// <remarks>
    /// Display only balance transactions is a default option.
    /// </remarks>
    public BalanceAffectingRecordsOnly BalanceAffectingRecordsOnly { get; set; }

    /// <summary>
    /// Indicates which fields appear in the response. Value is a single field or a comma-separated list of fields. The
    /// <c>transaction_info</c> value returns only the transaction details in the response. To include all fields in the response,
    /// specify <c>fields=all</c>
    /// </summary>
    public TransactionField[] Fields { get; set; }

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
    public TransactionStatus TransactionStatus { get; set; }

    /// <summary>
    /// Filters the transactions in the response by a PayPal transaction event code.
    /// </summary>
    public string TransactionType { get; set; }

    protected override void Validate()
    {
        base.Validate();

        if (EndDate is null)
        {
            throw new PayPalModelValidationException<ListTransactionsRequestDto>("EndDate is required.");
        }

        if (StartDate is null)
        {
            throw new PayPalModelValidationException<ListTransactionsRequestDto>("EndDate is required.");
        }

        if (Page is not null && Page < 1)
        {
            throw new PayPalModelValidationException<ListTransactionsRequestDto>("Page must be greater than 0.");
        }

        if (PageSize is not null && (PageSize < 1 || PageSize > 500))
        {
            throw new PayPalModelValidationException<ListTransactionsRequestDto>("PageSize must be between 1 and 500.");
        }

        if (TransactionId is not null && (TransactionId.Length < 17 || TransactionId.Length > 19))
        {
            throw new PayPalModelValidationException<ListTransactionsRequestDto>("Incorrect TransactionId lenght.");
        }
    }

    internal ListTransactionsRequest ToRequestModel()
    {
        Validate();

        return new ListTransactionsRequest
        {
            Jwt = Jwt,
            PaymentInstrumentType = PaymentInstrumentType.GetStringValue(),
            EndDate = EndDate?.ToString("O", CultureInfo.InvariantCulture),
            StartDate = StartDate?.ToString("O", CultureInfo.InvariantCulture),
            BalanceAffectingRecordsOnly = BalanceAffectingRecordsOnly.GetStringValue(),
            Fields = GetTransactionFieldsString(Fields),
            Page = Page,
            PageSize = PageSize,
            StoreId = StoreId,
            TerminalId = TerminalId,
            TransactionAmount = TransactionAmount,
            TransactionCurrency = TransactionCurrency,
            TransactionId = TransactionId,
            TransactionStatus = TransactionStatus.GetStringValue(),
            TransactionType = TransactionType
        };
    }

    private string GetTransactionFieldsString(TransactionField[] fields)
    {
        if (fields is null || fields.Length is 0)
        {
            return null;
        }

        if (fields.Contains(TransactionField.All))
        {
            return TransactionField.All.GetStringValue();
        }

        return string.Join(',', fields.Select(field => field.GetStringValue()));
    }
}
