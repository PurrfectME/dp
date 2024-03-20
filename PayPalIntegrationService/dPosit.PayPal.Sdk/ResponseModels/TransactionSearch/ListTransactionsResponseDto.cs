using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListTransactions;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.TransactionSearch;

public sealed class ListTransactionsResponseDto
{
    /// <summary>
    /// The merchant account number.
    /// </summary>
    public string AccountNumber { get; set; }

    /// <summary>
    /// The end date and time or the last date when the data can be served, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    public DateTimeOffset EndDate { get; set; }

    /// <summary>
    /// The date and time when the data was last refreshed, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    public DateTimeOffset LastRefreshedDatetime { get; set; }

    /// <summary>
    /// An array of related HATEOAS links.
    /// </summary>
    public LinkDescriptionDto[] Links { get; set; }

    /// <summary>
    /// A zero-relative index of transactions.
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// The start date and time, in Internet date and time format. Seconds are required while
    /// fractional seconds are optional.
    /// </summary>
    public DateTimeOffset StartDate { get; set; }

    /// <summary>
    /// The total number of transactions as an integer beginning with the specified <c>page</c> in the full result and not just in this
    /// response.
    /// </summary>
    public int TotalItems { get; set; }

    /// <summary>
    /// The total number of pages, as an <c>integer</c>, when the <c>total_items</c> is divided into pages of the specified <c>page_size</c>.
    /// </summary>
    public int TotalPages { get; set; }

    /// <summary>
    /// An array of transaction detail objects.
    /// </summary>
    /// <returns></returns>
    public TransactionDetailDto[] TransactionDetails { get; set; }

    internal static ListTransactionsResponseDto CreateFromModel(ListTransactionsResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ListTransactionsResponseDto
        {
            AccountNumber = model.AccountNumber,
            EndDate = DateTimeOffset.Parse(model.EndDate),
            LastRefreshedDatetime = DateTimeOffset.Parse(model.LastRefreshedDatetime),
            Links = model.Links?.Select(LinkDescriptionDto.CreateFromModel).ToArray(),
            Page = model.Page,
            StartDate = DateTimeOffset.Parse(model.StartDate),
            TotalItems = model.TotalItems,
            TotalPages = model.TotalPages,
            TransactionDetails = model.TransactionDetails?.Select(TransactionDetailDto.CreateFromModel).ToArray()
        };
    }
}
