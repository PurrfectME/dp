using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Extensions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class SellerProtectionDto
{
    /// <summary>
    /// An array of conditions that are covered for the transaction.
    /// </summary>
    public DisputeCategory[] DisputeCategories { get; set; }

    /// <summary>
    /// Indicates whether the transaction is eligible for seller protection. For information, see PayPal Seller Protection for Merchants.
    /// </summary>
    public SellerProtectionStatus Status { get; set; }

    internal static SellerProtectionDto CreateFromModel(SellerProtection model)
    {
        if (model is null)
        {
            return null;
        }

        return new SellerProtectionDto
        {
            DisputeCategories = model.DisputeCategories?.Select(Helpers.ParseDisputeCategoryValue).ToArray(),
            Status = Helpers.ParseSellerProtectionStatusValue(model.Status)
        };
    }
}
