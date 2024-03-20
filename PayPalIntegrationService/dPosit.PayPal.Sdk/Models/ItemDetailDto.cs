using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class ItemDetailDto
{
    /// <summary>
    /// An increment or decrement to a purchase amount.
    /// </summary>
    public MoneyDto AdjustmentAmount { get; set; }

    /// <summary>
    /// The delivery cost.
    /// </summary>
    public MoneyDto BasicShippingAmount { get; set; }

    /// <summary>
    /// An array of checkout options. Each option has a name and value.
    /// </summary>
    public CheckoutOptionDto[] CheckoutOptions { get; set; }

    /// <summary>
    /// The reduction in price associated with goods or a service.
    /// </summary>
    public MoneyDto DiscountAmount { get; set; }

    /// <summary>
    /// The cost for expedited delivery of the goods.
    /// </summary>
    public MoneyDto ExtraShippingAmount { get; set; }

    /// <summary>
    /// The amount of money charged for gift wrapping an item.
    /// </summary>
    public MoneyDto GiftWrapAmount { get; set; }

    /// <summary>
    /// A charge for processing the purchase of goods or services.
    /// </summary>
    public MoneyDto HandlingAmount { get; set; }

    /// <summary>
    /// A charge for guaranteeing the quality of a product or delivery of a product.
    /// </summary>
    public MoneyDto InsuranceAmount { get; set; }

    /// <summary>
    /// The invoice number. An alphanumeric string that identifies a billing for a merchant.
    /// </summary>
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// The amount of the payment for the item.
    /// </summary>
    public MoneyDto ItemAmount { get; set; }

    /// <summary>
    /// An item code that identifies a merchant's goods or service.
    /// </summary>
    public string ItemCode { get; set; }

    /// <summary>
    /// The item description.
    /// </summary>
    public string ItemDescription { get; set; }

    /// <summary>
    /// The item name.
    /// </summary>
    public string ItemName { get; set; }

    /// <summary>
    /// The item options. Describes option choices on the purchase of the item in some detail.
    /// </summary>
    public string ItemOptions { get; set; }

    /// <summary>
    /// The number of purchased units of goods or a service.
    /// </summary>
    public string ItemQuantity { get; set; }

    /// <summary>
    /// The cost for each instance of goods or a service.
    /// </summary>
    public MoneyDto ItemUnitPrice { get; set; }

    /// <summary>
    /// An array of tax amounts levied by a government on the purchase of goods or services.
    /// </summary>
    public ItemDetailTaxAmountDto[] TaxAmounts { get; set; }

    /// <summary>
    /// A rate, expressed in hundreds, that is used to calculate a levy for the purchase of goods or services.
    /// </summary>
    /// <value>
    /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as <c>19.99</c>.
    /// </value>
    public string TaxPercentage { get; set; }

    /// <summary>
    /// The sum of all factors, item cost, discounts, tax, shipping, and so on, that goes into the cost of an item.
    /// </summary>
    public MoneyDto TotalItemAmount { get; set; }

    internal static ItemDetailDto CreateFromModel(ItemDetail model)
    {
        if (model is null)
        {
            return null;
        }

        return new ItemDetailDto
        {
            AdjustmentAmount = MoneyDto.CreateFromModel(model.AdjustmentAmount),
            BasicShippingAmount = MoneyDto.CreateFromModel(model.BasicShippingAmount),
            CheckoutOptions = model.CheckoutOptions?.Select(CheckoutOptionDto.CreateFromModel).ToArray(),
            DiscountAmount = MoneyDto.CreateFromModel(model.DiscountAmount),
            ExtraShippingAmount = MoneyDto.CreateFromModel(model.ExtraShippingAmount),
            GiftWrapAmount = MoneyDto.CreateFromModel(model.GiftWrapAmount),
            HandlingAmount = MoneyDto.CreateFromModel(model.HandlingAmount),
            InsuranceAmount = MoneyDto.CreateFromModel(model.InsuranceAmount),
            InvoiceNumber = model.InvoiceNumber,
            ItemAmount = MoneyDto.CreateFromModel(model.ItemAmount),
            ItemCode = model.ItemCode,
            ItemDescription = model.ItemDescription,
            ItemName = model.ItemName,
            ItemOptions = model.ItemOptions,
            ItemQuantity = model.ItemQuantity,
            ItemUnitPrice = MoneyDto.CreateFromModel(model.ItemUnitPrice),
            TaxAmounts = model.TaxAmounts?.Select(ItemDetailTaxAmountDto.CreateFromModel).ToArray(),
            TaxPercentage = model.TaxPercentage,
            TotalItemAmount = MoneyDto.CreateFromModel(model.TotalItemAmount)
        };
    }
}
