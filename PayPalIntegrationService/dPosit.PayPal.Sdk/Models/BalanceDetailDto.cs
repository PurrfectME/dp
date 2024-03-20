using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class BalanceDetailDto
{
    /// <summary>
    /// Currency of the balances listed.
    /// </summary>
    public Currency Currency { get; set; }

    /// <summary>
    /// The total amount in PayPal account. It is the sum of all the other balances.
    /// </summary>
    public MoneyDto TotalBalance { get; set; }

    /// <summary>
    /// The amount of cash in an Account which is at the customer's disposal. This amount is captured at settlement cutoff time in the
    /// user's time zone as defined for the user.
    /// </summary>
    public MoneyDto AvailableBalance { get; set; }

    /// <summary>
    /// Optional field representing if the currency is primary currency or not.
    /// </summary>
    public bool? Primary { get; set; }

    /// <summary>
    /// Balance withheld in the account. The portion of funds that PayPal holds for the customer that is not currently at the customer's
    /// disposal.
    /// </summary>
    public MoneyDto WithheldBalance { get; set; }

    internal static BalanceDetailDto CreateFromModel(BalanceDetail model)
    {
        if (model is null)
        {
            return null;
        }

        return new BalanceDetailDto
        {
            Currency = Helpers.ParseCurrencyValue(model.Currency),
            TotalBalance = MoneyDto.CreateFromModel(model.TotalBalance),
            AvailableBalance = MoneyDto.CreateFromModel(model.AvailableBalance),
            Primary = model.Primary,
            WithheldBalance = MoneyDto.CreateFromModel(model.WithheldBalance)
        };
    }
}
