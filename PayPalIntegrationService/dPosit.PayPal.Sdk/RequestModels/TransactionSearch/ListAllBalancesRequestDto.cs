using System.Globalization;
using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListAllBalances;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.RequestModels.TransactionSearch;

public sealed class ListAllBalancesRequestDto : AuthorizedRequestDto<ListAllBalancesRequestDto>
{
    /// <summary>
    /// List balances in the response at the date time provided, will return the last refreshed balance in the system when not provided.
    /// </summary>
    public DateTimeOffset AsOfTime { get; set; }

    /// <summary>
    /// The currency.
    /// </summary>
    public Currency Currency { get; set; }

    internal ListAllBalancesRequest ToRequestModel()
    {
        Validate();

        return new ListAllBalancesRequest
        {
            Jwt = Jwt,
            AsOfTime = AsOfTime.ToString("O", CultureInfo.InvariantCulture),
            CurrencyCode = Currency.GetStringValue()
        };
    }
}
