using dPosit.PayPal.Sdk.Api.Models;
using dPosit.PayPal.Sdk.Exceptions;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PurchaseUnitRequestDto
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping,
    /// handling, insurance, and discounts, if any. If you specify <c>amount.breakdown</c>, the amount equals <c>item_total</c> plus
    /// <c>tax_total</c> plus <c>shipping</c> plus <c>handling</c> plus <c>insurance</c> minus <c>shipping_discount</c> minus <c>discount</c>.
    /// The amount must be a positive number.
    /// </summary>
    public AmountWithBreakdownDto Amount { get; set; }

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile client transactions with PayPal transactions. Appears in transaction and
    /// settlement reports but is not visible to the payer.
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// The purchase description. The maximum length of the character is dependent on the type of characters used. The character length is
    /// specified assuming a US ASCII character. Depending on type of character; (e.g. accented character, Japanese characters) the number
    /// of characters that that can be specified as input might not equal the permissible max length.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that
    /// the payer receives.
    /// </summary>
    public string InvoiceId { get; set; }

    /// <summary>
    /// An array of items that the customer purchases from the merchant.
    /// </summary>
    public ItemDto[] Items { get; set; }

    /// <summary>
    /// The merchant who receives payment for this transaction.
    /// </summary>
    public PayeeDto Payee { get; set; }

    /// <summary>
    /// Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for
    /// Capturing an order or Authorizing an Order.
    /// </summary>
    public PaymentInstructionDto PaymentInstruction { get; set; }

    /// <summary>
    /// The API caller-provided external ID for the purchase unit.
    /// </summary>
    /// <remarks>
    /// Required for multiple purchase units when you must update the order through <с>PATCH</с>. If you omit this value and the order
    /// contains only one purchase unit, PayPal sets this value to <c>default</c>.
    /// </remarks>
    public string ReferenceId { get; set; }

    /// <summary>
    /// The name and address of the person to whom to ship the items.
    /// </summary>
    public ShippingDetailDto ShippingDetail { get; set; }

    /// <summary>
    /// The dynamic text used to construct the statement descriptor that appears on a payer's card statement.
    /// </summary>
    /// <remarks>
    /// If an Order is paid using the "PayPal Wallet", the statement descriptor will appear in following format on the payer's card
    /// statement: <c>PAYPAL_prefix+(space)+merchant_descriptor+(space)+soft_descriptor</c>.
    /// </remarks>
    public string SoftDescriptor { get; set; }

    private void Validate()
    {
        if (Amount is null)
        {
            throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Amount is required.");
        }

        if (CustomId is not null && CustomId.Length > 127)
        {
            throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Incorrect CustomId lenght.");
        }

        if (Description is not null && Description?.Length > 127)
        {
            throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Incorrect Description lenght.");
        }

        if (InvoiceId is not null && InvoiceId?.Length > 127)
        {
            throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Incorrect InvoiceId lenght.");
        }

        if (Items is not null)
        {
            decimal tax = 0;
            foreach (var itemDto in Items)
            {
                if (itemDto.Tax is not null)
                {
                    tax += decimal.Parse(itemDto.Tax.Value) * int.Parse(itemDto.Quantity);
                }
            }

            if (tax > 0 && Amount.Breakdown.TaxTotal is null)
            {
                // If items.tax is specified, purchase_units[].amount.breakdown.tax_total is required.
                throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Tax total is required.");
            }

            if (decimal.Parse(Amount.Breakdown.TaxTotal.Value) != tax)
            {
                // Must equal items.tax * quantity for all items.
                throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Tax total is incorrect.");
            }
        }

        if (ReferenceId is not null && ReferenceId.Length > 256)
        {
            throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Incorrect ReferenceId lenght.");
        }

        if (SoftDescriptor is not null && SoftDescriptor.Length > 22)
        {
            throw new PayPalModelValidationException<PurchaseUnitRequestDto>("Incorrect SoftDescriptor lenght.");
        }
    }

    internal PurchaseUnitRequest ToRequestModel()
    {
        Validate();

        return new PurchaseUnitRequest
        {
            Amount = Amount.ToRequestModel(),
            CustomId = CustomId,
            Description = Description,
            InvoiceId = InvoiceId,
            Items = Items?.Select(item => item.ToRequestModel()).ToArray(),
            Payee = Payee?.ToRequestModel(),
            PaymentInstruction = PaymentInstruction?.ToRequestModel(),
            ReferenceId = ReferenceId,
            ShippingDetail = ShippingDetail?.ToRequestModel(),
            SoftDescriptor = SoftDescriptor
        };
    }
}
