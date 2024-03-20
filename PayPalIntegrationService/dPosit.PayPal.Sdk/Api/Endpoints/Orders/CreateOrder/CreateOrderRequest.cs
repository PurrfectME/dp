using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Orders.CreateOrder;

internal sealed class CreateOrderRequest : AuthorizedRequest
{
    /// <summary>
    /// The intent to either capture payment immediately or authorize a payment for an order after order creation.
    /// </summary>
    /// <value>
    /// "CAPTURE" - the merchant intends to capture payment immediately after the customer makes a payment.<br/>
    /// "AUTHORIZE" - the merchant intends to authorize a payment and place funds on hold after the customer makes a payment. Authorized
    /// payments are best captured within three days of authorization but are available to capture for up to 29 days. After the three-day
    /// honor period, the original authorized payment expires and you must re-authorize the payment. You must make a separate request to
    /// capture payments on demand. This intent is not supported when you have more than one `purchase_unit` within your order.
    /// </value>
    [JsonPropertyName("intent")]
    public string Intent { get; set; }

    /// <summary>
    /// An array of purchase units. Each purchase unit establishes a contract between a payer and the payee. Each purchase unit represents
    /// either a full or partial order that the payer intends to purchase from the payee.
    /// </summary>
    [JsonPropertyName("purchase_units")]
    public PurchaseUnitRequest[] PurchaseUnits { get; set; }

    /// <summary>
    /// Customize the payer experience during the approval process for the payment with PayPal.
    /// </summary>
    [JsonPropertyName("application_context")]
    public ApplicationContext ApplicationContext { get; set; }
}
