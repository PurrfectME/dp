using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class IncentiveDetailDto
{
    /// <summary>
    /// The incentive amount.
    /// </summary>
    public MoneyDto IncentiveAmount { get; set; }

    /// <summary>
    /// The code that identifies an incentive, such as a coupon.
    /// </summary>
    public string IncentiveCode { get; set; }

    /// <summary>
    /// The incentive program code that identifies a merchant loyalty or incentive program.
    /// </summary>
    public string IncentiveProgramCode { get; set; }

    /// <summary>
    /// The type of incentive, such as a special offer or coupon.
    /// </summary>
    public string IncentiveType { get; set; }

    internal static IncentiveDetailDto CreateFromModel(IncentiveDetail model)
    {
        if (model is null)
        {
            return null;
        }

        return new IncentiveDetailDto
        {
            IncentiveAmount = MoneyDto.CreateFromModel(model.IncentiveAmount),
            IncentiveCode = model.IncentiveCode,
            IncentiveProgramCode = model.IncentiveProgramCode,
            IncentiveType = model.IncentiveType
        };
    }
}
