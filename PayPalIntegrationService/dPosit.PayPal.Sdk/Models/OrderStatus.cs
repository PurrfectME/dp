namespace dPosit.PayPal.Sdk.Models;

public enum OrderStatus
{
    /// <summary>
    /// Default empty value.
    /// </summary>
    None,
    /// <summary>
    /// The order was created with the specified context.
    /// </summary>
    Created,
    /// <summary>
    /// The order was saved and persisted. The order status continues to be in progress until a capture is made with
    /// <c>final_capture = true</c> for all purchase units within the order.
    /// </summary>
    Saved,
    /// <summary>
    /// The customer approved the payment through the PayPal wallet or another form of guest or unbranded payment.
    /// For example, a card, bank account, or so on.
    /// </summary>
    Approved,
    /// <summary>
    /// All purchase units in the order are voided.
    /// </summary>
    Voided,
    /// <summary>
    /// The payment was authorized or the authorized payment was captured for the order.
    /// </summary>
    Completed,
    /// <summary>
    /// The order requires an action from the payer (e.g. 3DS authentication). Redirect the payer to the
    /// "rel":"payer-action" HATEOAS link returned as part of the response prior to authorizing or capturing the order.
    /// </summary>
    PayerActionRequired
}
