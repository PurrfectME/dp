using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class CartInfoDto
{
    /// <summary>
    /// An array of item details.
    /// </summary>
    public ItemDetailDto[] ItemDetails { get; set; }

    /// <summary>
    /// The ID of the invoice. Appears for only PayPal-generated invoices.
    /// </summary>
    public string PayPalInvoiceId { get; set; }

    /// <summary>
    /// Indicates whether the item amount or the shipping amount already includes tax.
    /// </summary>
    public bool? TaxInclusive { get; set; }

    internal static CartInfoDto CreateFromModel(CartInfo model)
    {
        if (model is null)
        {
            return null;
        }

        return new CartInfoDto
        {
            ItemDetails = model.ItemDetails?.Select(ItemDetailDto.CreateFromModel).ToArray(),
            PayPalInvoiceId = model.PayPalInvoiceId,
            TaxInclusive = model.TaxInclusive
        };
    }
}
