using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class SupplementaryDataDto
{
    /// <summary>
    /// Identifiers related to a specific resource.
    /// </summary>
    public RelatedIdsDto RelatedIds { get; set; }

    internal static SupplementaryDataDto CreateFromModel(SupplementaryData model)
    {
        if (model is null)
        {
            return null;
        }

        return new SupplementaryDataDto
        {
            RelatedIds = RelatedIdsDto.CreateFromModel(model.RelatedIds)
        };
    }
}
