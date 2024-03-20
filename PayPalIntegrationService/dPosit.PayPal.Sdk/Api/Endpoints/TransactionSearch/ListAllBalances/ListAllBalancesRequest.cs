namespace dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListAllBalances;

internal sealed class ListAllBalancesRequest : AuthorizedRequest
{
    /// <summary>
    /// List balances in the response at the date time provided, will return the last refreshed balance in the system when not provided.
    /// </summary>
    public string AsOfTime { get; set; }

    /// <summary>
    /// The three-character ISO-4217 currency code that identifies the currency.
    /// </summary>
    public string CurrencyCode { get; set; }

    public IDictionary<string, string> ToQueryParams()
    {
        return new Dictionary<string, string>
        {
            { "as_of_time", AsOfTime },
            { "currency_code", CurrencyCode }
        };
    }
}
