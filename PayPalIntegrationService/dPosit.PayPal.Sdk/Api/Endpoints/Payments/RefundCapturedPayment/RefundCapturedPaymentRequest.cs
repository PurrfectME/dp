using System.Text.Json.Serialization;
using dPosit.PayPal.Sdk.Api.Models;

namespace dPosit.PayPal.Sdk.Api.Endpoints.Payments.RefundCapturedPayment;

internal sealed class RefundCapturedPaymentRequest : AuthorizedRequest
{
    /// <summary>
    /// The amount to refund. To refund a portion of the captured amount, specify an amount. If amount is not specified, an amount equal
    /// to <c>captured amount - previous refunds</c> is refunded. The amount must be a positive number and in the same currency as the one
    /// in which the payment was captured.
    /// </summary>
    [JsonPropertyName("amount")]
    public Money Amount { get; set; }

    /// <summary>
    /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that
    /// the payer receives.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string InvoiceId { get; set; }

    /// <summary>
    /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
    /// </summary>
    [JsonPropertyName("note_to_payer")]
    public string NoteToPayer { get; set; }

    /// <summary>
    /// Any additional refund instructions to be set during refund payment processing. This object is only applicable to merchants that
    /// have been enabled for PayPal Commerce Platform for Marketplaces and Platforms capability. Please speak to your account manager if
    /// you want to use this capability.
    /// </summary>
    [JsonPropertyName("payment_instruction")]
    public PaymentInstruction PaymentInstruction { get; set; }
}
