using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class IncentiveInfoDto
{
    /// <summary>
    /// An array of incentive details.
    /// </summary>
    public IncentiveDetailDto[] IncentiveDetails { get; set; }

    internal static IncentiveInfoDto CreateFromModel(IncentiveInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new IncentiveInfoDto
        {
            IncentiveDetails = model.IncentiveDetails?.Select(IncentiveDetailDto.CreateFromModel).ToArray()
        };
    }
}
