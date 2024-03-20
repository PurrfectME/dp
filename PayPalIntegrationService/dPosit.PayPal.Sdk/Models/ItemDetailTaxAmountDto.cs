using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ItemDetailTaxAmountDto
{
    /// <summary>
    /// The tax levied by a government on the purchase of goods or services.
    /// </summary>
    public MoneyDto TaxAmount { get; set; }

    internal static ItemDetailTaxAmountDto CreateFromModel(ItemDetailTaxAmount model)
    {
        if (model is null)
        {
            return null;
        }

        return new ItemDetailTaxAmountDto
        {
            TaxAmount = MoneyDto.CreateFromModel(model.TaxAmount)
        };
    }
}
