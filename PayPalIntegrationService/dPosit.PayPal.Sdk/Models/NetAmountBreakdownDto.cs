using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class NetAmountBreakdownDto
{
    /// <summary>
    /// The converted payable amount.
    /// </summary>
    public MoneyDto ConvertedAmount { get; set; }

    /// <summary>
    /// The exchange rate that determines the amount that was debited from the merchant's PayPal account.
    /// </summary>
    public ExchangeRateDto ExchangeRate { get; set; }

    /// <summary>
    /// The net amount debited from the merchant's PayPal account.
    /// </summary>
    public MoneyDto PayableAmount { get; set; }

    internal static NetAmountBreakdownDto CreateFromModel(NetAmountBreakdown model)
    {
        if (model is null)
        {
            return null;
        }

        return new NetAmountBreakdownDto
        {
            ConvertedAmount = MoneyDto.CreateFromModel(model.ConvertedAmount),
            ExchangeRate = ExchangeRateDto.CreateFromModel(model.ExchangeRate),
            PayableAmount = MoneyDto.CreateFromModel(model.PayableAmount)
        };
    }
}
