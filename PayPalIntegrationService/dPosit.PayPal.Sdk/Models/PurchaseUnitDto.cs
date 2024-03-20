using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Models;

public sealed class PurchaseUnitDto
{
    /// <summary>
    /// The total order amount with an optional breakdown that provides details, such as the total item amount, total tax amount, shipping,
    /// handling, insurance, and discounts, if any. If you specify <c>amount.breakdown</c>, the amount equals <c>item_total</c> plus
    /// <c>tax_total</c> plus <c>shipping</c> plus <c>handling</c> plus <c>insurance</c> minus <c>shipping_discount</c> minus <c>discount</c>.
    /// The amount must be a positive number.
    /// </summary>
    public AmountWithBreakdownDto Amount { get; set; }

    /// <summary>
    /// The API caller-provided external ID. Used to reconcile API caller-initiated transactions with PayPal transactions. Appears in
    /// transaction and settlement reports.
    /// </summary>
    public string CustomId { get; set; }

    /// <summary>
    /// The purchase description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The PayPal-generated ID for the purchase unit. This ID appears in both the payer's transaction history and the emails that the
    /// payer receives. In addition, this ID is available in transaction and settlement reports that merchants and API callers can use
    /// to reconcile transactions. This ID is only available when an order is saved by calling <c>v2/checkout/orders/id/save</c>.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The API caller-provided external invoice ID for this order.
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
    /// The comprehensive history of payments for the purchase unit.
    /// </summary>
    public PaymentCollectionDto Payments { get; set; }

    /// <summary>
    /// The API caller-provided external ID for the purchase unit. Required for multiple purchase units when you must update the order
    /// through <c>PATCH</c>. If you omit this value and the order contains only one purchase unit, PayPal sets this value to <c>default</c>.
    /// </summary>
    /// <remarks>If there are multiple purchase units, reference_id is required for each purchase unit.</remarks>
    public string ReferenceId { get; set; }

    /// <summary>
    /// The shipping address and method.
    /// </summary>
    public ShippingDetailDto ShippingDetail { get; set; }

    /// <summary>
    /// The payment descriptor on account transactions on the customer's credit card statement, that PayPal sends to processors.
    /// The maximum length of the soft descriptor information that you can pass in the API field is 22 characters, in the following format:<br/>
    /// <c>22 - len(PAYPAL * (8)) - len(Descriptor in Payment Receiving Preferences of Merchant account + 1)</c>
    /// The PAYPAL prefix uses 8 characters.
    /// </summary>
    /// <remarks>
    /// The soft descriptor supports the following ASCII characters:<br/>
    /// - alphanumeric characters<br/>
    /// - dashes<br/>
    /// - asterisks<br/>
    /// - periods (.)<br/>
    /// - spaces<br/>
    /// For Wallet payments marketplace integrations:<br/>
    /// - the merchant descriptor in the Payment Receiving Preferences must be the marketplace name.<br/>
    /// - you can't use the remaining space to show the customer service number.<br/>
    /// For unbranded payments (Direct Card) marketplace integrations, use a combination of the seller name and phone number.
    /// </remarks>
    public string SoftDescriptor { get; set; }

    internal static PurchaseUnitDto CreateFromModel(PurchaseUnit model)
    {
        if (model is null)
        {
            return null;
        }

        return new PurchaseUnitDto
        {
            Amount = AmountWithBreakdownDto.CreateFromModel(model.Amount),
            CustomId = model.CustomId,
            Description = model.Description,
            Id = model.Id,
            InvoiceId = model.InvoiceId,
            Items = model.Items?.Select(ItemDto.CreateFromModel).ToArray(),
            Payee = PayeeDto.CraeteFromModel(model.Payee),
            PaymentInstruction = PaymentInstructionDto.CreateFromModel(model.PaymentInstruction),
            Payments = PaymentCollectionDto.CreateFromModel(model.Payments),
            ReferenceId = model.ReferenceId,
            ShippingDetail = ShippingDetailDto.CreateFromModel(model.ShippingDetail),
            SoftDescriptor = model.SoftDescriptor
        };
    }
}
