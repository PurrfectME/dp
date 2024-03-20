using dPosit.PayPal.Sdk.Api.Endpoints.TransactionSearch.ListAllBalances;
using dPosit.PayPal.Sdk.Models;

namespace dPosit.PayPal.Sdk.ResponseModels.TransactionSearch;

public sealed class ListAllBalancesResponseDto
{
    /// <summary>
    /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number
    /// is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
    /// </summary>
    public string AccountId { get; set; }

    /// <summary>
    /// The requested date and time or the last date and time when the balances can be served, in Internet date and time format.
    /// Seconds are required while fractional seconds are optional.
    /// </summary>
    public DateTimeOffset AsOfTime { get; set; }

    /// <summary>
    /// An array of balance detail objects.
    /// </summary>
    public BalanceDetailDto[] Balances { get; set; }

    /// <summary>
    /// The date and time when the balances was last refreshed, in Internet date and time format. Seconds are required.
    /// Fractional seconds are optional.
    /// </summary>
    public DateTimeOffset LastRefreshTime { get; set; }

    internal static ListAllBalancesResponseDto CreateFromModel(ListAllBalancesResponse model)
    {
        if (model is null)
        {
            return null;
        }

        return new ListAllBalancesResponseDto
        {
            AccountId = model.AccountId,
            AsOfTime = DateTimeOffset.Parse(model.AsOfTime),
            Balances = model.Balances?.Select(BalanceDetailDto.CreateFromModel).ToArray(),
            LastRefreshTime = DateTimeOffset.Parse(model.LastRefreshTime)
        };
    }
}
