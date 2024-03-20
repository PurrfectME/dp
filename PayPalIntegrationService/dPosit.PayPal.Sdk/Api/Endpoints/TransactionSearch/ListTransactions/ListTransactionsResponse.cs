using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListTransactions;

internal sealed class ListTransactionsResponse
{
    /// <summary>
    /// The merchant account number.
    /// </summary>
    [JsonPropertyName("account_number")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// The end date and time or the last date when the data can be served, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("end_date")]
    public string EndDate { get; set; }

    /// <summary>
    /// The date and time when the data was last refreshed, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("last_refreshed_datetime")]
    public string LastRefreshedDatetime { get; set; }

    /// <summary>
    /// An array of related HATEOAS links.
    /// </summary>
    [JsonPropertyName("links")]
    public LinkDescription[] Links { get; set; }

    /// <summary>
    /// A zero-relative index of transactions.
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// The start date and time, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    [JsonPropertyName("start_date")]
    public string StartDate { get; set; }

    /// <summary>
    /// The total number of transactions as an integer beginning with the specified <c>page</c> in the full result and not just in this
    /// response.
    /// </summary>
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// The total number of pages, as an <c>integer</c>, when the <c>total_items</c> is divided into pages of the specified <c>page_size</c>.
    /// </summary>
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    /// <summary>
    /// An array of transaction detail objects.
    /// </summary>
    /// <returns></returns>
    [JsonPropertyName("transaction_details")]
    public TransactionDetail[] TransactionDetails { get; set; }
}
